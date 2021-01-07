import { SessionService } from './../../services/session.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.css']
})
export class ToolbarComponent implements OnInit {

  constructor(public sessionService: SessionService, private router: Router) {}

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

  goToLoginPage(): void {
    this.router.navigate(['login']);
  }

}
