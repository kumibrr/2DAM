import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ChuckJoke } from '../interfaces/chuckJoke';

@Injectable({
  providedIn: 'root'
})
export class ChuckJokesService {

  constructor(private http: HttpClient) { }

  getCategories() {
    return this.http.get('https://api.chucknorris.io/jokes/categories').toPromise();
  }

  getRandomJoke(category: string) {
    const url = 'https://api.chucknorris.io/jokes/random?category=' + category;
    return this.http.get<ChuckJoke>(url).toPromise();
  }
}
