import { IncidentService } from './../services/incident.service';
import { AddIncidencePage } from './../pages/add-incidence/add-incidence.page';
import { Component } from '@angular/core';
import { IonRouterOutlet, ModalController } from '@ionic/angular';
import { Incident } from '../interfaces/interfaces';
import { Router } from '@angular/router';

@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page {

  public segment: 'current' | 'solved' = 'current';
  public segmentColor: 'danger' | 'success' = 'danger';

  constructor(
    private modalController: ModalController,
    private routerOutlet: IonRouterOutlet,
    public incidentService: IncidentService,
    private router: Router)
    { }

  toggle(): void {
    if (this.segment === 'current') {
      this.segment = 'solved';
      this.segmentColor = 'success';
    } else {
      this.segment = 'current';
      this.segmentColor = 'danger';
    }
  }

  async addIncidence(): Promise<void> {
    const modal = await this.modalController.create({
      component: AddIncidencePage,
      swipeToClose: true,
      presentingElement: this.routerOutlet.nativeEl,
    });
    modal.onDidDismiss()
      .then(data => {
        this.incidentService.addIncidence(data.data.level, data.data.title, data.data.description);
      });

    return await modal.present();
  }

  goToDetails(id: number) {
    this.router.navigate(['incidence-detail', {id}]);
  }

  setClass(incident: Incident): string {
    let r = '';
    if (incident.hasBeenSolved === true) {
      r += ' solved';
      switch (incident.level) {
        case 0:
          r += ' lowS';
          break;
        case 1:
          r += ' mediumS';
          break;
        case 2:
          r += ' highS';
          break;
        case 3:
          r += ' extremeS';
          break;
      }
    } else {
      switch (incident.level) {
        case 0:
          r += ' low';
          break;
        case 1:
          r += ' medium';
          break;
        case 2:
          r += ' high';
          break;
        case 3:
          r += ' extreme';
          break;
      }
    }
    return r;
  }

}
