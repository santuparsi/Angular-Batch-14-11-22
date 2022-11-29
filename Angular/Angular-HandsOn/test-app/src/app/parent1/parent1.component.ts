import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parent1',
  templateUrl: './parent1.component.html',
  styleUrls: ['./parent1.component.css']
})
export class Parent1Component implements OnInit {
paranetmsg:string='message from parent'
un:string=''
parenetname=''
  constructor() { }

  ngOnInit(): void {
  }
  setName()
  {
    this.parenetname=this.un
  }

}
