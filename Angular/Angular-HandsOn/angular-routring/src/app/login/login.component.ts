import { Component } from '@angular/core';
import { User } from '../user';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  users:User[]=[];
  user:User;
  errMsg:string='';
  constructor(private router:Router)
  {
    this.user=new User();
    this.users=[
      {userName:'Rohan',password:"12345",role:'User'},
      {userName:'Karan',password:"12345",role:'Admin'},
      {userName:'Suman',password:"12345",role:'User'},
      {userName:'Charan',password:"12345",role:'User'},
    ];
  }
  Validate()
  {
    let uname=this.user.userName;
    let pwd=this.user.password;
    let obj=this.users.find(u=>u.userName==uname && u.password==pwd);
    console.log(obj);
    if(obj!=null)
    {
      sessionStorage.setItem('user','validated')
      if(obj.role=='Admin')
      {
        //redirect to admin-dashboard
        this.router.navigateByUrl('admin-dashboard')
      }
      else if(obj.role=='User')
      {
        //redirect to user-dashboard
        this.router.navigateByUrl('user-dashboard')
      }
    }
    else
    {
      this.errMsg='Invalid Credentials'
    }
  }
}
