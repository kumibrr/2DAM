import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AlertController } from '@ionic/angular';
import { Incident } from 'src/app/interfaces/interfaces';
import { IncidentService } from 'src/app/services/incident.service';

@Component({
  selector: 'app-incidence-detail',
  templateUrl: './incidence-detail.page.html',
  styleUrls: ['./incidence-detail.page.scss'],
})
export class IncidenceDetailPage{

  public incident: Incident;
  public class: string;

  constructor(
    private activatedRoute: ActivatedRoute,
    private incidentService: IncidentService,
    private alertController: AlertController
    ){
    this.incident = this.incidentService.getFromId(+this.activatedRoute.snapshot.paramMap.get('id'));
    }

  async toggleSolved(): Promise<void> {
    if (this.incident.hasBeenSolved === true) {
      const alert = await this.alertController.create({
        header: 'Cambiar estado',
        message: 'La incidencia volverá a estar marcada como activa.',
        buttons: [
          {
            text: 'Cancelar'
          },
          {
            text: 'Aceptar',
            handler: () => {
              this.incident.hasBeenSolved = false;
              this.incidentService.toggleSolved(+this.activatedRoute.snapshot.paramMap.get('id'));
            }
          }
        ]
      });
      await alert.present();
    } else {
      this.incident.hasBeenSolved = true;
      this.incidentService.toggleSolved(+this.activatedRoute.snapshot.paramMap.get('id'));
    }
  }

}
