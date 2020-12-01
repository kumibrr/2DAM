import { Component, OnInit, Renderer2 } from '@angular/core';

@Component({
  selector: 'app-style-selector',
  templateUrl: './style-selector.component.html',
  styleUrls: ['./style-selector.component.css']
})
export class StyleSelectorComponent implements OnInit {

  private darkMode = false;

  constructor(private renderer: Renderer2) { }

  ngOnInit(): void {
  }

  toggle(): void {
    if (this.darkMode) {
      this.renderer.removeClass(document.body, 'bootstrap-dark');
      this.darkMode = false;
    } else {
      this.renderer.addClass(document.body, 'bootstrap-dark');
      this.darkMode = true;
    }
  }

}
