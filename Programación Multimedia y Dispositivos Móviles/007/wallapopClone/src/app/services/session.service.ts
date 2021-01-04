import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SessionService {

  private token = '';

  constructor() { }

  isLogged(): boolean {
    if (this.token !== '') {
      return true;
    } else {
      return false;
    }
  }

  logOut(): void {
    this.token = '';
  }

}
