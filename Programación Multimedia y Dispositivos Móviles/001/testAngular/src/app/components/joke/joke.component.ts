import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Joke } from 'src/app/class/joke';

@Component({
  selector: 'app-joke',
  templateUrl: './joke.component.html',
  styleUrls: ['./joke.component.css']
})
export class JokeComponent implements OnInit {

  @Input('joke') joke: Joke;
  @Output() jokeToDelete = new EventEmitter<Joke>();
  public isHidden = true;

  constructor() { }

  ngOnInit(): void {
  }

  togglePunchline() {
    this.isHidden = !this.isHidden;
  }

  sendDeleteJokeEv(ev) {
    this.jokeToDelete.emit(this.joke);
  }

}
