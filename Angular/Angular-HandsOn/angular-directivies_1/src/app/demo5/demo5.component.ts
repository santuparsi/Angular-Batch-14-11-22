import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo5',
  templateUrl: './demo5.component.html',
  styleUrls: ['./demo5.component.css']
})
export class Demo5Component implements OnInit {
flag=true;
temp=1;
  constructor() { }

  ngOnInit(): void {
  }
  Setflag()
  {
    this.flag=!this.flag;
  }
}
