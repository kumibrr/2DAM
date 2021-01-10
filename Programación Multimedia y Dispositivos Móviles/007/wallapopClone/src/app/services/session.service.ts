import { UserInfo } from './../classes/UserInfo';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SessionService {

  private token = 'add';
  private userInfo: UserInfo = new UserInfo('unknown', 'unknown');

  constructor() { }

  isLogged(): boolean {
    if (this.token !== '') {
      return true;
    } else {
      return false;
    }
  }

  logOut(): Promise<string> {
    return new Promise((resolve, reject) => {
      this.token = '';
      this.userInfo = new UserInfo('unknown', 'unknown');
      resolve('user logged of ok');
    });
  }

  logIn(): Promise<string> {
    return new Promise((resolve, reject) => {
      this.token = 'asd';
      this.userInfo = new UserInfo('Pepe palotes', 'ad');
      resolve('user authentication ok');
    });
  }

  getUserInfo(): UserInfo {
    return this.userInfo;
  }

}
