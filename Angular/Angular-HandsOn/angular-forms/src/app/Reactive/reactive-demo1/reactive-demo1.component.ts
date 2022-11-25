import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
@Component({
  selector: 'app-reactive-demo1',
  templateUrl: './reactive-demo1.component.html',
  styleUrls: ['./reactive-demo1.component.css'],
})
export class ReactiveDemo1Component implements OnInit {
  submitted = false;
  constructor() {}

  ngOnInit(): void {}
  form = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.minLength(3)]),
    email: new FormControl('', [Validators.required, Validators.email]),
    body: new FormControl('', Validators.required),
  });
//property
  get f() {
    return this.form.controls;
  }

  submit() {
    this.submitted = true;
    console.log(this.form.value); //retrun all the form control values
    console.log(this.form.value["name"]); //retunrs name value
    console.log(this.form.value['body']); //returns body value
    console.log(this.form.value["email"]); //returns email value
  }
}
