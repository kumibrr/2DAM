import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Product } from './../../classes/Product';
import { ProductService } from './../../services/product.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainPageComponent implements OnInit {

  public products: Product[] = [];

  constructor(private productService: ProductService, private router: Router) {
    this.getData();
  }

  ngOnInit(): void {
  }

  async getData(): Promise<void> {
    await this.productService.getMainPageItems()
    .subscribe(r => {
      this.products = r;
    });
  }

  goToProductPage(index: number): void {
    this.router.navigate(['product', this.products[index]]);
  }

}
