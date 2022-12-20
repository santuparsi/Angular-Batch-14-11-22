import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Item } from '../Models/item';
import { Order } from '../Models/order';
import { Payment } from '../Models/payment';
@Injectable({
  providedIn: 'root'
})
export class UserService {
  url:string="";
  constructor(private service:HttpClient) { }
  public Search(itemName:string):Observable<Item>
  {
    return this.service.get<Item>(this.url+'GetItem/'+itemName);
  }
  public Buy(payment:Payment):Observable<any>
  {
    return this.service.post(this.url+'Purchase/',payment);
  }

}
