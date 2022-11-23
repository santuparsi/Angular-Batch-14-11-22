import { Component } from '@angular/core';
import { Product } from '../product';
@Component({
  selector: 'app-product-view',
  templateUrl: './product-view.component.html',
  styleUrls: ['./product-view.component.css']
})
export class ProductViewComponent {
products:Product[]=[];
item:Product
flag:boolean=false;
visible:boolean=false;
constructor()
{
  this.item=new Product();
}
Save()
{
  console.log(this.item);
  this.products.push(this.item); //added item to the array
  console.log(this.products);
  this.item=new Product();
  this.flag=true;
}
SetVisible()
{
  this.visible=!this.visible;
}
}
