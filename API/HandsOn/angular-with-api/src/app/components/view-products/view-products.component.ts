import { Component } from '@angular/core';
import { ProductService } from 'src/app/shared/product.service';
import { Product } from 'src/app/models/product';
@Component({
  selector: 'app-view-products',
  templateUrl: './view-products.component.html',
  styleUrls: ['./view-products.component.css']
})
export class ViewProductsComponent {
products:Product[]=[];
constructor(private productService:ProductService)
{
  //invoking GetAllProduct() from service
  productService.GetAllProducts().subscribe(response=>
    {
      this.products=response;
      console.log(this.products);
    });
}
}
