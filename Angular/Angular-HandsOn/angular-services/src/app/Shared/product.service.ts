import { Injectable } from '@angular/core';
import { Product } from '../product';
@Injectable({
  providedIn: 'root'
})
export class ProductService {
  products: Product[] = [];
  product?: Product;
  constructor() {
    this.product = new Product();
  }
  AddProduct(product: Product): void {
    this.products.push(product);
  }
  GetProduct(productId: number): Product | undefined {
    this.product = this.products.find(p => p.productId == productId)
    return this.product;

  }
  GetProducts():Product[]
  {
    return this.products;
  }
}
