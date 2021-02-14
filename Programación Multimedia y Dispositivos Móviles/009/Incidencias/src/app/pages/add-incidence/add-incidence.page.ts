import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-incidence',
  templateUrl: './add-incidence.page.html',
  styleUrls: ['./add-incidence.page.scss'],
})
export class AddIncidencePage implements OnInit {

  public form: FormGroup;

  constructor(private formBuilder: FormBuilder) {
    this.form = formBuilder.group({
      title: ['', Validators.required],
      description: [''],
      low: [false],
      medium: [false],
      high: [false],
      extreme: [false]
    });
  }

  ngOnInit() {
  }

  checkChange(c: number): void {
    console.log(this.form);
    this.form.controls.low.setValue(false);
    this.form.controls.medium.setValue(false);
    this.form.controls.high.setValue(false);
    this.form.controls.extreme.setValue(false);
  }

}
