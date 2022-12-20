import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Item } from '../Models/item';

@Injectable({
  providedIn: 'root'
})
export class AdminService {
  url:string=environment.admin_url
  constructor(private service:HttpClient) { }
  //Get All Project
  public GetAll():Observable<Item[]>
  {
    return this.service.get<Item[]>(this.url+'GetItems');
  }
  public GetItemById(id:number):Observable<Item>
  {
    return this.service.get<Item>(this.url+'GetItem/'+id);
  }
  public AddItem(item:Item):Observable<any>//Add Item
  {
    console.log(item)
    return this.service.post(this.url+'AddItem',item);
  }
  public UpdateItem(item:Item):Observable<any> //Update Item
  {
    return this.service.put(this.url+'EditItem',item);
  }
  // public DeleteProduct(id:number):Observable<any>//DeleteItem
  // {
  //   return this.service.delete(this.url+'DeleteProduct/'+id);
  // }

}
