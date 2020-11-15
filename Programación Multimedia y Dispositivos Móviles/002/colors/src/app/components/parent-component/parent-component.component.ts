import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parent-component',
  templateUrl: './parent-component.component.html',
  styleUrls: ['./parent-component.component.css']
})
export class ParentComponentComponent implements OnInit {

  constructor() { }

  public colors = ['red', 'green', 'blue'];
  public colorsCurrentIndex = 0;

  ngOnInit(): void {
  }

  cycleColor() {
    this.colorsCurrentIndex++;
    if (this.colorsCurrentIndex > 2) {
      this.colorsCurrentIndex = 0;
    }
  }

}
