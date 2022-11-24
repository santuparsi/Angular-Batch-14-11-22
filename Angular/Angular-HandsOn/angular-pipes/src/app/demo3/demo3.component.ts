import { Component } from '@angular/core';

@Component({
  selector: 'app-demo3',
  templateUrl: './demo3.component.html',
  styleUrls: ['./demo3.component.css']
})
export class Demo3Component {
  users:any[]=[]
  constructor()
  {
    this.users=[
      {id:1,name:'Rohan',gender:'Male'},
      {id:2,name:'Viashnavi',gender:'FeMale'},
      {id:3,name:'Suren',gender:'Male'},
      {id:4,name:'Brunda',gender:'FeMale'},
      {id:5,name:'Abhishek',gender:'Male'},
      {id:6,name:'Pooja',gender:'FeMale'},
    ]
  }
}
