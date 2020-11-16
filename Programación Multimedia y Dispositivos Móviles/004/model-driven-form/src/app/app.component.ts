import { ChuckJokesService } from './services/chuck-jokes.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'model-driven-form';

  public chuckFg: FormGroup;
  public jokeCategories: any;
  private chosenCategory: any;
  public joke: any;

  constructor(private fb: FormBuilder, private _cs: ChuckJokesService) {
    this.chuckFg = fb.group({
      category: fb.control('', Validators.required)
    });
  }

  ngOnInit(): void {
    this._cs.getCategories()
    .then((r) => {
      this.jokeCategories = r;
    });
  }

  categorySelected(ev: any) {
    this.chosenCategory = ev.target.value;
    this.getJoke();
  }

  getJoke() {
    this._cs.getRandomJoke(this.chosenCategory)
    .then(r => {
      this.joke = r;
      console.log(this.joke);
    });
  }

}
