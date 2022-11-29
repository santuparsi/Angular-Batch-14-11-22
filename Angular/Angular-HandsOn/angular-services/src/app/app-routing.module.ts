import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Demo1Component } from './demo1/demo1.component';
import { Demo2Component } from './demo2/demo2.component';
import { Demo3Component } from './demo3/demo3.component';
import { ProductAppComponent } from './product-app/product-app.component';

const routes: Routes = [
  {path:'demo1',component:Demo1Component},
  {path:'demo2',component:Demo2Component},
  {path:'demo3',component:Demo3Component},
  {path:'product-app',component:ProductAppComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
