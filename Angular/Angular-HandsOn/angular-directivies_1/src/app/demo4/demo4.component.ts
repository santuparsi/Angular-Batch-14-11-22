import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo4',
  templateUrl: './demo4.component.html',
  styleUrls: ['./demo4.component.css']
})
export class Demo4Component implements OnInit {
flag=1;
scolor:string='';
  constructor() { }

  ngOnInit(): void {
  }
  Set()
  {
    if(this.flag==1)
    {
      this.flag=2;
    }
    else if(this.flag==2)
    {
      this.flag=1;
    }
  }


}
