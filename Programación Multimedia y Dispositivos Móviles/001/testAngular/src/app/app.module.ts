import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { JokeComponent } from './components/joke/joke.component';
import { JokeListComponent } from './components/joke-list/joke-list.component';
import { AngularFireModule } from '@angular/fire';
import { JokeFormComponent } from './components/joke-form/joke-form.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

const firebaseConfig = {
  apiKey: "AIzaSyDPm8N6NHxR0wRqjyhb8JwocT-DbEy2edA",
  authDomain: "tutoangular-8bfab.firebaseapp.com",
  databaseURL: "https://tutoangular-8bfab.firebaseio.com",
  projectId: "tutoangular-8bfab",
  storageBucket: "tutoangular-8bfab.appspot.com",
  messagingSenderId: "465212538673",
  appId: "1:465212538673:web:8cf3a44a964b4cfa943a10"
};

@NgModule({
  declarations: [
    AppComponent,
    JokeComponent,
    JokeListComponent,
    JokeFormComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AngularFireModule.initializeApp(firebaseConfig),
    ReactiveFormsModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
