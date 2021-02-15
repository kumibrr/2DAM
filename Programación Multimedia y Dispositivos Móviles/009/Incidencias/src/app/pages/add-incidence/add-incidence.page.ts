import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Animation, AnimationController, IonNote, ModalController } from '@ionic/angular';

@Component({
  selector: 'app-add-incidence',
  templateUrl: './add-incidence.page.html',
  styleUrls: ['./add-incidence.page.scss'],
})
export class AddIncidencePage{

  public form: FormGroup;
  public levelLabel = '';
  public triedToSubmit = false;
  private animationNote: Animation;

  @ViewChild('note') note: ElementRef;
  @ViewChild('level') level: ElementRef;
  @ViewChild('title') title: ElementRef;

  constructor(
    private formBuilder: FormBuilder,
    private animationController: AnimationController,
    private modalController: ModalController)
    {
    this.form = formBuilder.group({
      title: ['', Validators.required],
      description: [''],
      level: ['', Validators.required],
      low: [false],
      medium: [false],
      high: [false],
      extreme: [false]
    });
  }

  ionViewDidEnter(){
    this.animationNote = this.animationController.create()
    .addElement(this.note.nativeElement)
    .duration(150)
    .iterations(1)
    .fromTo('opacity', 0, 1)
    .fromTo('transform', 'translateX(30px)', 'translateX(0)');
  }

  async checkChange(c: number): Promise<void> {
    this.form.controls.low.setValue(false);
    this.form.controls.medium.setValue(false);
    this.form.controls.high.setValue(false);
    this.form.controls.extreme.setValue(false);
    this.form.controls.level.setValue(c);
    switch (c) {
      case 0:
        this.levelLabel = 'Leve';
        break;
      case 1:
        this.levelLabel = 'Medio';
        break;
      case 2:
        this.levelLabel = 'Alto';
        break;
      case 3:
        this.levelLabel = 'Extremo';
        break;
    }
    console.log(this.form.controls.level.value);
    await this.animationNote.play();
  }

  validate() {
    this.triedToSubmit = true;
    if (this.form.valid) {
      this.modalController.dismiss(
        {
          level: this.form.controls.level.value,
          title: this.form.controls.title.value,
          description: this.form.controls.description.value
        }
      );
    }
  }

  dismiss(): void {
    this.modalController.dismiss();
  }

}
