import { SessionService } from './../services/session.service';
import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OnlyLoggedUserGuardGuard implements CanActivate {

  constructor(private sessionService: SessionService, private router: Router) { }

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    if (this.sessionService.isLogged()) {
      return true;
    } else {
      this.router.navigate(['login']);
      return false;
    }
  }

}
