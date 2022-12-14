import { Injectable } from '@angular/core';
import { Product } from '../models/product';
import { HttpClient } from '@angular/common/http';
import  { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
api_url:string='http://localhost:5284/api/Product/';
  constructor(private http:HttpClient) { }
  GetAllProducts():Observable<Product[]> //Get all the products
  {
    return this.http.get<Product[]>(this.api_url+'GetAllProducts');
  }
  GetProduct(id:number):Observable<Product> //Get Product by id
  {
    return this.http.get<Product>(this.api_url+'GetProduct/'+id);
  }
  AddProduct(item:Product):Observable<any> //Add Product
  {
    return this.http.post(this.api_url+'AddProduct',item);
  }
  EditProduct(item:Product):Observable<any> //Edit Product
  {
    return this.http.put(this.api_url+'EditProduct',item);
  }
  DeleteProduct(id:number):Observable<any> //Delete Product
  {
    return this.http.delete(this.api_url+'DeleteProduct/'+id);
  }
}
