import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class JokeService {

  constructor(private http: HttpClient) {}

  getJokes() {
    return new Promise((resolve, reject) => {
      this.http.post('./assets/jokes.json', {})
      .subscribe(data => {
        resolve(data);
      })
    });
  }


}
