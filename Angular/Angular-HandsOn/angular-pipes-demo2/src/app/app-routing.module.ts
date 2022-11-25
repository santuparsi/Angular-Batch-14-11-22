import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DemoComponent } from './demo/demo.component';
import { StudentViewComponent } from './student-view/student-view.component';

const routes: Routes = [
  {path:'demo',component:DemoComponent},
  {path:'',component:StudentViewComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
