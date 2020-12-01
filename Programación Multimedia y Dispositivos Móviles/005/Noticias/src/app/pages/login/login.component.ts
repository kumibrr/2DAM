import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public loginForm: FormGroup;

  constructor(private fb: FormBuilder, private router: Router) {
    this.loginForm = fb.group({
      username: new FormControl('', Validators.required),
      password: new FormControl('', (Validators.required && Validators.minLength(8)))
    });
   }

  ngOnInit(): void {
  }

  logIn() {
    if (this.loginForm.valid) {
      this.router.navigate(['admin']);
    }
  }
}
