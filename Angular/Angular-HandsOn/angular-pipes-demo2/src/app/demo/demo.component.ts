import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {

  title:string='Pipe Demo';
  price:number=345;
  bookingDate:Date=new Date(2021,2,21);
  obj:any={Eid:1,Ename:'Rohan',Salary:23000};
  constructor() { }

  ngOnInit(): void {
  }

}
