import { SessionService } from './../../services/session.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public loginForm: FormGroup;

  constructor(private fb: FormBuilder, private sessionService: SessionService, private router: Router) {
    this.loginForm = this.fb.group({
      username: ['', [Validators.required]],
      password: ['', [Validators.required]],
    });
  }

  ngOnInit(): void {
  }

  checkvalid(): void {
    this.loginForm.controls.username.markAsTouched();
    this.loginForm.controls.password.markAsTouched();
    console.log(this.loginForm.valid);
    if (this.loginForm.valid) {
      this.sessionService.logIn()
      .then(r => {
        console.log(r);
        this.router.navigate(['main']);
      });
    }
  }

}
