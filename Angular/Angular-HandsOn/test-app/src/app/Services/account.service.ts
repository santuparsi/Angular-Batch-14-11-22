import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../Models/user';
import { Observable } from 'rxjs';
import { Login } from '../Models/login';
import { Authuser } from '../Models/authuser';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  account_url='http://localhost:29657/api/Account/';
  constructor(private service:HttpClient) { }
  public Register(user:User):Observable<any>
  {
    return this.service.post(this.account_url+"Register",user);
  }
  public Login(login:Login):Observable<Authuser>
  {
    return this.service.post<Authuser>(this.account_url+"Login",login);

  }
}
