import { JokeService } from './../../services/joke.service';
import { Component, OnInit } from '@angular/core';
import { Joke } from 'src/app/class/joke';

@Component({
  selector: 'app-joke-list',
  templateUrl: './joke-list.component.html',
  styleUrls: ['./joke-list.component.css']
})
export class JokeListComponent implements OnInit {

  public jokes: Joke[] = [new Joke('que malo el brii', 'en el lolito mis muertos')];

  constructor(private jokeService: JokeService) { }

  ngOnInit(): void {
    // this.jokeService.getJokes()
    // .subscribe(rawJoke => {
    //   rawJoke.map((joke: any) => {
    //     this.jokes.push(new Joke(joke.question, joke.punchline));
    //   });
    // });
  }

  deleteJoke() {
    
  }

  createJoke() {
    
  }

}
