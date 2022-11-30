import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PostViewComponent } from './post-view/post-view.component';
import { PostComponent } from './post/post.component';

const routes: Routes = [
  {path:'post/:id',component:PostComponent},
  {path:'post-list',component:PostViewComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
