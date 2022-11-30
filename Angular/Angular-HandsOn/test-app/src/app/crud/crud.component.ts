import { Component, OnInit } from '@angular/core';
import { CrudHttpService } from '../crud-http.service';

@Component({
  selector: 'app-crud',
  templateUrl: './crud.component.html',
  styleUrls: ['./crud.component.css']
})
export class CrudComponent implements OnInit {
  products: any = []
  id?: number
  title?: string;
  constructor(private crudHttpService: CrudHttpService) { }

  ngOnInit(): void {
    this.loadProducts();
  }
  loadProducts() {
    this.crudHttpService.list().subscribe((response) => {
      this.products = response;
    }, (error => {

    }));
  }
  createProduct() {
    let product = {
      id: new Date().getTime(),
      title: this.title
    }
    this.crudHttpService.create(product).subscribe((response) => {
      this.loadProducts();
    }, (error => {

    }));
  }
  editProduct() {
    let data = {
      id: this.id,
      title: this.title
    }
    this.crudHttpService.update(data.id, data).subscribe((response) => {
      this.loadProducts();
    }, (error => {

    }));
  }

  deleteProduct(id: any) {
    this.crudHttpService.delete(id).subscribe((response) => {
      this.loadProducts();
    }, (error => {
    }));
  }
}
