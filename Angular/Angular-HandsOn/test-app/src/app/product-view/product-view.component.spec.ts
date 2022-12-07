import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { HttpClient,HttpHeaderResponse } from "@angular/common/http";
import { ProductViewComponent } from './product-view.component';
import { ProductService } from '../Shared/product.service';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
describe('ProductViewComponent', () => {
  let component: ProductViewComponent;
  let fixture: ComponentFixture<ProductViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProductViewComponent ],
      imports: [ HttpClientTestingModule ],
      providers:[ProductService]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
