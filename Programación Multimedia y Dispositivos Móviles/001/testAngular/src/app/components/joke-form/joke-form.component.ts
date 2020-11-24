import { Component, ElementRef, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
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

  public myForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.myForm = this.fb.group({
      question: fb.control('', [Validators.required, Validators.minLength(6)]),
      punchline: fb.control('', [Validators.required, Validators.minLength(6)])
    });
  }

  ngOnInit(): void {}

  clearTextInputs() {
    this.question.nativeElement.value = '';
    this.punchline.nativeElement.value = '';
  }

  sendSubmitJokeEv() {
    this.jokeToCreate.emit(new Joke(this.question.nativeElement.value, this.punchline.nativeElement.value, null));
    this.clearTextInputs();
  }

}
