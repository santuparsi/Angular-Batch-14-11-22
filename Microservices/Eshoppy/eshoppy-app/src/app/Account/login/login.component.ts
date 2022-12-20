import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Login } from 'src/app/Models/login';
import { User } from 'src/app/Models/user';
import { AccountService } from 'src/app/Services/account.service';
import { Router } from '@angular/router';
import { Authuser } from 'src/app/Models/authuser';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  submitted = false;
  login: Login;
  authuser:Authuser;
  errMsg:string='';
  constructor(private frombuilder: FormBuilder, private account_service: AccountService,private router:Router) {
    this.login = new Login();
  }

  ngOnInit() {
    this.loginForm = this.frombuilder.group({
      email: ['', Validators.required],
      pwd: ['', Validators.required]
    });
  }
  onSubmit() {
    this.submitted = true;
    if (this.loginForm.valid) {

      this.login.email=this.loginForm.value["email"];
      this.login.password=this.loginForm.value['pwd']
      this.account_service.Login(this.login).subscribe(response => {
        this.authuser=response
      if(this.authuser!=null)
      {
        localStorage.token=this.authuser.token; //store token value
        console.log(localStorage.token);
      if(this.authuser.role.toUpperCase()=="USER"||this.authuser.role.toUpperCase()=="CUSTOMER")
      {
        //landing to user dash-board
        localStorage.userId=this.authuser.userId;
        this.router.navigateByUrl('/user');
      }
      else
      {
          //landing to admin dash-board
          this.router.navigateByUrl('/admin');
      }
      }
      else
      {
        this.errMsg='Invalid Credentials';
      console.log("Login Fail");

      }
      })

    }


  }
  // convenience getter for easy access to form fields
  get f() { return this.loginForm.controls; }
  onReset() {

    this.submitted = false;
    this.loginForm.reset();
  }

}
