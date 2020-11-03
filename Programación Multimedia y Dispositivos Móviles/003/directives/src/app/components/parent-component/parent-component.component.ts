import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parent-component',
  templateUrl: './parent-component.component.html',
  styleUrls: ['./parent-component.component.css']
})
export class ParentComponentComponent implements OnInit {

  constructor() { }

  public bool = false;

  public arr = new Array(100);

  ngOnInit(): void {
  }

}
