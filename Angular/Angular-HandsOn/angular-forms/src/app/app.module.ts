import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { Demo1Component } from './demo1/demo1.component';
import { TemplateDemo1Component } from './Template/template-demo1/template-demo1.component';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { ReactiveDemo1Component } from './Reactive/reactive-demo1/reactive-demo1.component';
import { ReactiveDemo2Component } from './Reactive/reactive-demo2/reactive-demo2.component';
import { TemplateDemo2Component } from './Template/template-demo2/template-demo2.component';

@NgModule({
  declarations: [
    AppComponent,
    Demo1Component,
    TemplateDemo1Component,
    ReactiveDemo1Component,
    ReactiveDemo2Component,
    TemplateDemo2Component
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
