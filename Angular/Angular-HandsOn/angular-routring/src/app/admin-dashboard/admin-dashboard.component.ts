import { Component } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.css']
})
export class AdminDashboardComponent {
  constructor(private router:Router) {
    console.log(sessionStorage.getItem('user'));
    if(sessionStorage.getItem('user')==null)
    {
      this.router.navigate(['login']);
    }
  }
  LogOut()
  {
    this.router.navigate(['login']);
    sessionStorage.clear();
  }

}
