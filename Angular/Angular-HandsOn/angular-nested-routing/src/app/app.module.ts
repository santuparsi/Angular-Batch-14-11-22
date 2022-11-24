import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AdminDashboardComponent } from './Admin/admin-dashboard/admin-dashboard.component';
import { AddBookComponent } from './Admin/add-book/add-book.component';
import { ViewBooksComponent } from './Admin/view-books/view-books.component';
import { EditBookComponent } from './Admin/edit-book/edit-book.component';
import { SearchBookComponent } from './User/search-book/search-book.component';
import { ViewCartComponent } from './User/view-cart/view-cart.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { UserDashboardComponent } from './User/user-dashboard/user-dashboard.component';

@NgModule({
  declarations: [
    AppComponent,
    AdminDashboardComponent,
    AddBookComponent,
    ViewBooksComponent,
    EditBookComponent,
    SearchBookComponent,
    ViewCartComponent,
    LoginComponent,
    RegisterComponent,
    UserDashboardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
