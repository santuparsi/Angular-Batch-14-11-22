import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DemoComponent } from './demo/demo.component';
import { TitlePipe } from './title.pipe';
import { SearchFilterPipe } from './search-filter.pipe';
import { StudentViewComponent } from './student-view/student-view.component';
import { FormsModule } from '@angular/forms';
import { TestPipe } from './test.pipe';

@NgModule({
  declarations: [
    AppComponent,
    DemoComponent,
    TitlePipe,
    SearchFilterPipe,
    StudentViewComponent,
    TestPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
