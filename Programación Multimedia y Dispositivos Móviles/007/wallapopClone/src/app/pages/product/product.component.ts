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

  // tslint:disable-next-line: max-line-length
  public product: Product = new Product('', '', 0, 'EUR', new Date(), new Date(), new UserInfo('unknown', ''), -6.099025, -6.099025, false, ['./assets/placeholder-image.png']);

  constructor(private route: ActivatedRoute) {
    route.params.subscribe(r => {
      this.product = r as Product;
      console.log(this.product);
    });
  }

  ngOnInit(): void {
  }

}
