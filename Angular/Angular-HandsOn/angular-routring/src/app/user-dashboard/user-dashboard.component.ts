import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user-dashboard',
  templateUrl: './user-dashboard.component.html',
  styleUrls: ['./user-dashboard.component.css']
})
export class UserDashboardComponent {
 uname:any='';
  constructor(private router:Router) {
    //read value from the local storage
    this.uname=localStorage.getItem('un');
  }
  LogOut()
  {
    this.router.navigate(['login']);
  }
}
