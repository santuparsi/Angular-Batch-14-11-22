import { TestBed } from '@angular/core/testing';
import { HttpClient,HttpHeaderResponse } from "@angular/common/http";
import { ProductService } from './product.service';
import { Product } from '../Models/product';
import { RouterTestingModule } from '@angular/router/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
describe('ProductService', () => {
  let service: ProductService;

  beforeEach(() => {
    TestBed.configureTestingModule(
      { imports: [ HttpClientTestingModule,RouterTestingModule ],
        providers:[ProductService]});
    service = TestBed.inject(ProductService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
  it('should return product-list', () => {
    let list: Product[];
    service.GetAll().subscribe((res)=>
    {
      list=res;
    })
    expect(5).toEqual(list.length)
  });

});
