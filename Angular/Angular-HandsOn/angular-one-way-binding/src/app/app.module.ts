import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { Demo1Component } from './demo1/demo1.component';
import { CustomerComponent } from './customer/customer.component';
import { StudentComponent } from './student/student.component';
import { ProperyBindingDemoComponent } from './propery-binding-demo/propery-binding-demo.component';
import { Demo2Component } from './demo2/demo2.component';
import { StudentListComponent } from './student-list/student-list.component';

@NgModule({
  declarations: [
    AppComponent,
    Demo1Component,
    CustomerComponent,
    StudentComponent,
    ProperyBindingDemoComponent,
    Demo2Component,
    StudentListComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
