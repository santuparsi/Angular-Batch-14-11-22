import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HelloService {

  constructor() { }
  HelloUser()
  {
    return 'Hello Good Morning User';
  }
}
