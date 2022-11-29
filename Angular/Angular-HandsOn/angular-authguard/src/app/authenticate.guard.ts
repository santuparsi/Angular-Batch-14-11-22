import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class AuthenticateGuard implements CanActivate {
  constructor(private router:Router,private authService:AuthService)
  {

  }
  canActivate(): boolean {
    if (!this.authService.gettoken()) {
      this.router.navigateByUrl("/login");
  }
  return this.authService.gettoken();


  }

}
