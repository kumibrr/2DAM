import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Joke } from 'src/app/class/joke';

@Component({
  selector: 'app-joke-form',
  templateUrl: './joke-form.component.html',
  styleUrls: ['./joke-form.component.css']
})
export class JokeFormComponent implements OnInit {

  @Output() jokeToCreate = new EventEmitter<Joke>();

  constructor() {}

  ngOnInit(): void {
  }

  sendSubmitJokeEv(question, punchline) {
    this.jokeToCreate.emit(new Joke(question, punchline));
  }

}
