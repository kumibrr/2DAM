import { SessionService } from './../../services/session.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.css']
})
export class ToolbarComponent implements OnInit {

  public isLogged: boolean;

  constructor(private sessionService: SessionService) {
    this.isLogged = sessionService.isLogged();
  }

  ngOnInit(): void {
  }

  goMain(): void {
    console.log('ey');
  }

}
