import { Component, ElementRef, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';
import { Joke } from 'src/app/class/joke';

@Component({
  selector: 'app-joke-form',
  templateUrl: './joke-form.component.html',
  styleUrls: ['./joke-form.component.css']
})
export class JokeFormComponent implements OnInit {

  @Output() jokeToCreate = new EventEmitter<Joke>();
  
  @ViewChild('question') question: ElementRef;
  @ViewChild('punchline') punchline: ElementRef;


  constructor() {}

  ngOnInit(): void {
  }

  clearTextInputs() {
    this.question.nativeElement.value = '';
    this.punchline.nativeElement.value = '';
  }

  sendSubmitJokeEv() {
    this.jokeToCreate.emit(new Joke(this.question.nativeElement.value, this.punchline.nativeElement.value, null));
    this.clearTextInputs();
  }

}
