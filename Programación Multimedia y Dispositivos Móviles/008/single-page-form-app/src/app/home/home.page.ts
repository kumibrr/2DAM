import { Course } from './../model/Course.model';
import { CourseService } from './../services/course.service';
import { Component } from '@angular/core';
import {  FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { AlertController } from '@ionic/angular';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {

  public courses: Course[];
  public courseForm: FormGroup;

  constructor(
    private courseService: CourseService,
    private formBuilder: FormBuilder,
    private alertController: AlertController
    ) {
    this.courseService.getCourses().subscribe(r => {
      this.courses = r;
     });

    this.courseForm = formBuilder.group({
      title: new FormControl('', Validators.required),
      score: new FormControl('', [Validators.required, Validators.min(0), Validators.max(5)])
    });
  }

  remove(item: Course): void {
    this.courseService.removeCourse(item);
  }

  addCourse(title: string, score: number): void {
    if (this.courseForm.valid) {
      this.courseService.addCourse(title, score);
    } else if (this.courseForm.controls.title.hasError('required') || this.courseForm.controls.score.hasError('required')) {
      this.invalidForm('Empty Field', 'Please fill all fields to submit a new course');
    } else {
      this.invalidForm('Wrong value', 'Score must be between 0 and 5, please enter a valid value');
    }
  }

  async invalidForm(header: string, message: string) {
    const alert = await this.alertController.create({
      header,
      message,
      buttons: ['OK']
    });
    await alert.present();
  }

}
