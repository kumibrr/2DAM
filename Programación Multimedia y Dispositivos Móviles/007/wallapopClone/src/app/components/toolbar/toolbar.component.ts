import { SessionService } from './../../services/session.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.css']
})
export class ToolbarComponent implements OnInit {

  constructor(public sessionService: SessionService) {}

  ngOnInit(): void {
  }

  goMain(): void {
    console.log('ey');
  }

  logOut(): void {
    this.sessionService.logOut()
    .then((r) => {
      console.log(r);
      window.location.reload();
    });
  }

}
