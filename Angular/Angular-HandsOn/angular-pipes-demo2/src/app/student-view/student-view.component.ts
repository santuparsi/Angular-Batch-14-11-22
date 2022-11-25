import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-student-view',
  templateUrl: './student-view.component.html',
  styleUrls: ['./student-view.component.css']
})
export class StudentViewComponent implements OnInit {
  public query:any=''
  students=[
      {"id":1,"name":'Rohan',"email":'rohan@gmail.com'},
      {'id':2,'name':'Roshan','email':'roshan@gmail.com'},
      {'id':3,'name':'Rahim','email':'rahim@gmail.com'},
      {'id':4,'name':'Rajan','email':'rajan@gmail.com'},
      {'id':5,'name':'Sunil','email':'suni@gmail.com'},
      {'id':6,'name':'Suren','email':'suren@gmail.com'},
      {'id':7,'name':'Rishab','email':'rishab@gmail.com'},
      {'id':8,'name':'Rishi','email':'rishi@gmail.com'},
      {'id':9,'name':'Mohan','email':'mohan@gmail.com'},
      {'id':10,'name':'Monita','email':'monita@gmail.com'}

  ]
  constructor() {
    
   }

  ngOnInit(): void {
  }

}
