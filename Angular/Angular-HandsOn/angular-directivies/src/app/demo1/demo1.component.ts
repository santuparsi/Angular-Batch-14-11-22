import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class Demo1Component implements OnInit {
isVisible=false;
  constructor() { }

  ngOnInit(): void {
  }
setVisible()
{
if(this.isVisible==true)
{
  this.isVisible=false;
}
else if(this.isVisible==false)
{
  this.isVisible=true;
}
}
}
