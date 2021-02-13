import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-incidence',
  templateUrl: './add-incidence.page.html',
  styleUrls: ['./add-incidence.page.scss'],
})
export class AddIncidencePage implements OnInit {

  public level = [
    {value: 0, class: 'low', note: 'Leve', isChecked: false},
    {value: 1, class: 'medium', note: 'Medio', isChecked: false},
    {value: 2, class: 'high', note: 'Alto', isChecked: false},
    {value: 3, class: 'extreme', note: 'Extremo', isChecked: false}
  ];
  public form: FormGroup;

  constructor(private formBuilder: FormBuilder) {
    this.form = formBuilder.group({
      title: ['', Validators.required],
      description: [''],
      level: ['', Validators.required]
    });
  }

  ngOnInit() {
  }

  checkChange(checked): void {
    console.log(checked);
    this.level.forEach(c => {
      if (c.value !== checked.value) {
        c.isChecked = false;
      } else {
        c.isChecked = true;
      }
    });
  }

}
