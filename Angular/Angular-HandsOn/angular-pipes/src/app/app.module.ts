import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Demo1Component } from './demo1/demo1.component';
import { GreetPipe } from './greet.pipe';
import { Demo2Component } from './demo2/demo2.component';
import { Demo3Component } from './demo3/demo3.component';
import { TitlePipe } from './title.pipe';

@NgModule({
  declarations: [
    AppComponent,
    Demo1Component,
    GreetPipe,
    Demo2Component,
    Demo3Component,
    TitlePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
