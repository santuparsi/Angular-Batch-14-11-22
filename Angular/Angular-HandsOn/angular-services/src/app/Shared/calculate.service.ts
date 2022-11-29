import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CalculateService {

  constructor() { }
  //service-methods
  Add(n1:number,n2:number):number
  {
    return n1+n2;
  }
  Square(n:number):number
  {
    return n*n;
  }
  Greet(name:string):string
  {
    return "Hello "+name;
  }
}
