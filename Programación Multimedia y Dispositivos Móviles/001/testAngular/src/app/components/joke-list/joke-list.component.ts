import { JokeService } from './../../services/joke.service';
import { Component, OnInit } from '@angular/core';
import { Joke } from 'src/app/class/joke';

@Component({
  selector: 'app-joke-list',
  templateUrl: './joke-list.component.html',
  styleUrls: ['./joke-list.component.css']
})
export class JokeListComponent implements OnInit {

  public jokes: Joke[] = [];

  constructor(private jokeService: JokeService) { }

  ngOnInit(): void {
    this.jokeService.getJokes()
    .subscribe(rawJokes => {
      this.jokes = rawJokes.map<Joke>((rawJoke: any) => new Joke(rawJoke.question, rawJoke.punchline, rawJoke.creationDate));
    });
  }

  createJoke(jokeCapturedFromEv) {
    this.jokeService.submitJoke(jokeCapturedFromEv);
  }

  deleteJoke(jokeCapturedFromEv) {
    // console.log(jokeCapturedFromEv);
    this.jokeService.deleteJoke(jokeCapturedFromEv);
  }



}
