import { Component } from '@angular/core';
import { Router,ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.css']
})
export class AdminDashboardComponent {
  uname:string='';
  constructor(private router:Router,private activatedRoute:ActivatedRoute) {
    this.activatedRoute.params.subscribe(p=>this.uname=p['un']); //read route parameter value from the url
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
