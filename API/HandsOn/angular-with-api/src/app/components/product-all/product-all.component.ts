import { Component } from '@angular/core';
import { ProductService } from 'src/app/shared/product.service';
import { Product } from 'src/app/models/product';
@Component({
  selector: 'app-product-all',
  templateUrl: './product-all.component.html',
  styleUrls: ['./product-all.component.css']
})
export class ProductAllComponent {
  item: Product
  products: Product[] = [];
  //price:number=12.2;
  constructor(private productService: ProductService) {
    this.item = new Product();
    this.GetAll();
  }
  Save() //Add Product
  {
    console.log(this.item)
    this.item.productId = 0;
    this.productService.AddProduct(this.item).subscribe(response => {
      this.item = new Product(); //reset the product
      this.GetAll();
    })
  }
  Delete() //Delete Product
  {
    this.productService.DeleteProduct(this.item.productId!).subscribe(response => {
      this.GetAll();
    })
  }
  Remove(id:number) //Delete Product
  {
  console.log(id);
    this.productService.DeleteProduct(id).subscribe(response => {
      this.GetAll();
    })
  }
  Edit() //Edit Product
  {
    this.productService.EditProduct(this.item).subscribe(response => {
      this.GetAll();
    })
  }
  Search() {
    this.productService.GetProduct(this.item.productId!).subscribe(response => {
      this.item = response;
      console.log(this.item);
    });
  }
  GetAll() {
    this.productService.GetAllProducts().subscribe(response => {
      this.products = response;
      console.log(this.products);
    });
  }

}
