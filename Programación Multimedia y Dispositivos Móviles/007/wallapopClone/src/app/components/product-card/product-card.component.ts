import { Product } from './../../classes/Product';
import { Component, Input, OnInit } from '@angular/core';
import { UserInfo } from 'src/app/classes/UserInfo';

@Component({
  selector: 'app-product-card',
  templateUrl: './product-card.component.html',
  styleUrls: ['./product-card.component.css']
})
export class ProductCardComponent implements OnInit {

  @Input() product: Product = new Product(
    'unknown', '', 0, 'EUR', new Date(), new Date(), new UserInfo('unknown', 'unknown'), 'none', true, ['./assets/placeholder-image.png']
  );

  constructor() { }

  ngOnInit(): void {
  }

}
