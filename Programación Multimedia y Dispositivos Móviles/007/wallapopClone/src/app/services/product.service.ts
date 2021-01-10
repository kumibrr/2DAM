import { Observable } from 'rxjs';
import { Product } from './../classes/Product';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }

  getMainPageItems(): Observable<Product[]> {
      return this.http.get<Product[]>('./assets/product-list.json');
  }

  // getSingleItem(id: number): Observable<Product> {
  //   return this.http.post<Product>('./assets/product-list.json', {id});
  // }
}
