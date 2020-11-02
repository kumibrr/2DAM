import { Injectable } from '@angular/core';
import { AngularFirestore } from '@angular/fire/firestore';

@Injectable({
  providedIn: 'root'
})
export class JokeService {

  constructor(private firestore: AngularFirestore) {}

  getJokes() {
    return this.firestore.collection("jokes").valueChanges();
  }

}
