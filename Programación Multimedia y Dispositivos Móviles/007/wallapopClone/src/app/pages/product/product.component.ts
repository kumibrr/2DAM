import { ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/classes/Product';
import { UserInfo } from 'src/app/classes/UserInfo';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  public product: Product = new Product('', '', 0, 'EUR', new Date(), new Date(), new UserInfo('unknown', ''), '', false, ['./assets/placeholder-image.png']);

  constructor(private route: ActivatedRoute) {
    route.params.subscribe(r => {
      this.product = r as Product;
    });
  }

  ngOnInit(): void {
  }

}
