import { Component } from '@angular/core';
import { Student } from '../student';
@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent {
  students:Student[]=[];
  constructor() {
    this.students=[
      {studentId:1234,studentName:'Rohan',studentAge:10,studentStd:'IV'},
      {studentId:4532,studentName:'Deepak',studentAge:11,studentStd:'V'},
      {studentId:2313,studentName:'Brunda',studentAge:10,studentStd:'IV'},
      {studentId:6789,studentName:'Abhishek',studentAge:11,studentStd:'V'},
      {studentId:6543,studentName:'Vaishnavi',studentAge:10,studentStd:'IV'},
      {studentId:8976,studentName:'Deepraj',studentAge:12,studentStd:'VI'},
      {studentId:3214,studentName:'Abhinav',studentAge:10,studentStd:'IV'},
      {studentId:3987,studentName:'Druva',studentAge:11,studentStd:'V'},
    ];
  }
}
