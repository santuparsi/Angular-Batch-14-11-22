import { Component } from '@angular/core';
import { Product } from '../product';
import { ProductService } from '../Shared/product.service';

@Component({
  selector: 'app-product-app',
  templateUrl: './product-app.component.html',
  styleUrls: ['./product-app.component.css']
})
export class ProductAppComponent {
  products?:Product[];
  product:Product
constructor(private productService:ProductService) {
  this.product=new Product();
  this.products=this.productService.GetProducts();

}
Save()
{
  this.productService.AddProduct(this.product);
  this.product=new Product();
}
Search()
{
  let id:number|undefined=this.product.productId;
  this.product=this.productService.GetProduct(id);
}

}
