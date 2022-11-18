import { Component } from '@angular/core';

@Component({
  selector: 'app-demo2',
  templateUrl: './demo2.component.html',
  styleUrls: ['./demo2.component.css']
})
export class Demo2Component {
title:string='Hello Angular Users';
cities:string[]=['banglore','chennai','hyderabad','delhi'];
stds:number[]=[1,2,3,4,5];
}
