import { Injectable } from '@angular/core';
import { AngularFirestore } from '@angular/fire/firestore';
import firebase from 'firebase/app';

@Injectable({
  providedIn: 'root'
})
export class JokeService {

  constructor(private afs: AngularFirestore) {}

  getJokes() {
    return this.afs.collection('jokes', ref => ref.orderBy('creationDate', 'desc')).valueChanges();
  }

  submitJoke(joke) {
    const data = {question: joke.question, punchline: joke.punchline, creationDate: firebase.firestore.FieldValue.serverTimestamp()};
    return this.afs.collection('jokes').add(data);
  }

  deleteJoke(joke) {
    this.afs.collection('jokes', ref => ref.where('creationDate', '==', joke.creationDate)).get()
    .subscribe(docu => {
      docu.forEach((item) => {
        this.afs.collection('jokes').doc(item.id).delete();
      });
    });
  }



}
