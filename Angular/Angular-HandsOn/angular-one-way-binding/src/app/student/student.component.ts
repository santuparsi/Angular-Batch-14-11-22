import { Component } from '@angular/core';
import { Student } from '../student';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent {
  //create student object
  student:Student;
  constructor()
  {
    this.student=new Student();
    this.student={studentId:1234,studentName:'Rohan',studentAge:10,studentStd:'IV'};
  }
  EditStudent()
  {
    this.student.studentAge=11;
  }

}
