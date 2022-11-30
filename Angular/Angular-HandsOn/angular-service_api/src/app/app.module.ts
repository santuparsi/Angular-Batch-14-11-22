import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PostViewComponent } from './post-view/post-view.component';
import { PostService } from './Shared/Shared/post.service';
import { PostComponent } from './post/post.component';

@NgModule({
  declarations: [
    AppComponent,
    PostViewComponent,
    PostComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [PostService],
  bootstrap: [AppComponent]
})
export class AppModule { }
