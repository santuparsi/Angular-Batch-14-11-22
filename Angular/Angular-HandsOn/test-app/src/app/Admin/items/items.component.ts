import { Component, OnInit } from '@angular/core';
import { Item } from 'src/app/Models/item';
import { AdminService } from 'src/app/Services/admin.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-items',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.css']
})
export class ItemsComponent implements OnInit {
items:Item[];
  constructor(private adminService:AdminService,private router:Router) { 
    this.adminService.GetAll().subscribe(response=>{
      this.items=response
    })
  }

  ngOnInit(): void {
  }
  GetItem(id:string)
  {
    localStorage.ItemId=id;
    console.log(id);
    this.router.navigateByUrl('/edit-item')
  }
  DeleteItem(id:string)
  {
    console.log(id);
  }

}
