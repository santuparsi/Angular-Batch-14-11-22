import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ProductService } from './shared/product.service';
import { ViewProductsComponent } from './components/view-products/view-products.component';
import { ProductAllComponent } from './components/product-all/product-all.component';
@NgModule({
  declarations: [
    AppComponent,
    ViewProductsComponent,
    ProductAllComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
