import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaderResponse } from "@angular/common/http";
import {  Observable} from "rxjs";
import { Product } from '../Models/product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  //path:string="https://productapi85.azurewebsites.net/api/Product/"
  path:string="http://localhost:58090/api/Product/";
  constructor(private http:HttpClient) { }
  public GetAll():Observable<Product[]>
  {
    return this.http.get<Product[]>(this.path+"GetAll")
  }
  public Get(pid:number):Observable<Product>
  {
    console.log(pid);
    return this.http.get<Product>(this.path+'GetById/'+pid)
  }
  public Add(item:Product):Observable<any>
  {
    console.log(item);
    return this.http.post(this.path+"Add",item);
  }
  public Update(item:Product):Observable<any>
  {
    console.log(item);
    return this.http.put<any>(this.path+"Update",item);
  }
  public Delete(pid:number):Observable<any>
  {
    console.log(pid);
    return this.http.delete<any>(this.path+'Delete/'+pid)
  }
}
