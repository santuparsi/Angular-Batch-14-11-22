import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo3',
  templateUrl: './demo3.component.html',
  styleUrls: ['./demo3.component.css']
})
export class Demo3Component implements OnInit {
countries=["India","US","UK","China"]; //array
country:string='India';
india_cities=["Delhi","Chennai","Banglore"];
  constructor() { }

  ngOnInit(): void {
  }

}
