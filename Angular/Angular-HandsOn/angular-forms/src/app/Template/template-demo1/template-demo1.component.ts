import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-template-demo1',
  templateUrl: './template-demo1.component.html',
  styleUrls: ['./template-demo1.component.css']
})
export class TemplateDemo1Component implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  submit(form:any){
    var firstName = form.firstName;
    console.log(firstName);
  
    var lastName = form.lastName;
    console.log(lastName);
  
    var comment = form.comment;
    console.log(comment);
  }


}
