import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddBookComponent } from './Admin/add-book/add-book.component';
import { AdminDashboardComponent } from './Admin/admin-dashboard/admin-dashboard.component';
import { EditBookComponent } from './Admin/edit-book/edit-book.component';
import { ViewBooksComponent } from './Admin/view-books/view-books.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { SearchBookComponent } from './User/search-book/search-book.component';
import { UserDashboardComponent } from './User/user-dashboard/user-dashboard.component';
import { ViewCartComponent } from './User/view-cart/view-cart.component';

const routes: Routes = [
  {path:'login',component:LoginComponent},
  {path:'register',component:RegisterComponent},
  {path:'admin-dashboard',component:AdminDashboardComponent,children:[
    {path:'add-book',component:AddBookComponent},
    {path:'view-books',component:ViewBooksComponent},
    {path:'edit-book',component:EditBookComponent}
  ]},
  {path:'user-dashboard',component:UserDashboardComponent,children:[
    {path:'search-book',component:SearchBookComponent},
    {path:'view-cart',component:ViewCartComponent}
  ]}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
