import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './Account/login/login.component';
import { RegisterComponent } from './Account/register/register.component';
import { AdditemComponent } from './Admin/additem/additem.component';
import { AdmingDashboardComponent } from './Admin/adming-dashboard/adming-dashboard.component';
import { ItemsComponent } from './Admin/items/items.component';
import { UpdateitemComponent } from './Admin/updateitem/updateitem.component';
import { Login } from './Models/login';
import { SearchComponent } from './User/search/search.component';
import { UserDashboardComponent } from './User/user-dashboard/user-dashboard.component';

const routes: Routes = [
  {path:'login',component:LoginComponent},
  {path:'register',component:RegisterComponent},
  {path:'add-item',component:AdditemComponent},
  {path:'edit-item',component:UpdateitemComponent},
  {path:'viewall',component:ItemsComponent},
  {path:'search',component:SearchComponent},
  {path:'admin',component:AdmingDashboardComponent},
  {path:'user',component:UserDashboardComponent},
  {path:'logout',component:LoginComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
