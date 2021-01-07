import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-product-card',
  templateUrl: './product-card.component.html',
  styleUrls: ['./product-card.component.css']
})
export class ProductCardComponent implements OnInit {

  @Input() imgSrc = './assets/placeholder-image.png';
  @Input() productName = '';
  @Input() price = 0.0;

  constructor() { }

  ngOnInit(): void {
  }

}
