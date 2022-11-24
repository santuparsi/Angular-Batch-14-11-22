import { Component } from '@angular/core';

@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class Demo1Component {
  employeeName:string='Abhijit';
  joinDate:Date=new Date(2016,2,21);
  salary:number=45000;
  
}
