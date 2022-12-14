import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductAllComponent } from './components/product-all/product-all.component';
import { ViewProductsComponent } from './components/view-products/view-products.component';

const routes: Routes = [
  {path:'',component:ViewProductsComponent},
  {path:'all',component:ProductAllComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
