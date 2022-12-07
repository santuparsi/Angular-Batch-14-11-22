import { Component, OnInit } from '@angular/core';
import { Product } from '../Models/product';
import { ProductService } from '../Shared/product.service';

import { Router } from '@angular/router';


@Component({
  selector: 'app-product-view',
  templateUrl: './product-view.component.html',
  styleUrls: ['./product-view.component.css']
})
export class ProductViewComponent implements OnInit {
list:Product[];
pid:number;
pname:string;
price:number;
stock:number;
obj:Product;
errmsg:string;
dispaly:boolean=false
  constructor(private service:ProductService,private router:Router) {
    this.service.GetAll().subscribe(i=>{
      this.list=i
      if(this.list.length>0)
      {
        this.dispaly=true;
      }
      console.log(this.list)
    })
  }

  ngOnInit(): void {
  }
  Search()
  {
    this.service.Get(this.pid).subscribe(item=>{

      console.log(item);
this.obj=item;
      this.pname=this.obj.pname;
      this.stock=this.obj.stock;
      this.price=this.obj.price;
      this.errmsg="";
    },
    (error)=>{
      console.log(error);
console.log(error.error);
console.log(error.status);
console.log(error.statusText);
if(error.status==404)
{
  this.router.navigateByUrl("/notfound")
}
    })

  }
  public Add()
  {
   this.obj=new Product();
   this.obj.pid=this.pid;
   this.obj.pname=this.pname;
   this.obj.price=this.price;
   this.obj.stock=this.stock;
  this.service.Add(this.obj).subscribe((response)=>
  {
    console.log(response);
  },(error)=>{
    console.log(error)
    console.log(error.error.text)
  })
  }
  public Update()
  {
    this.obj={pid:Number(this.pid),
      pname:this.pname,
      price:this.price,
    stock:this.stock};
    this.service.Update(this.obj).subscribe(i=>{
      console.log(i)
    })
  }
  public Delete()
  {
    this.service.Delete(this.pid).subscribe(res=>{
      console.log(res);
    })
  }

}
