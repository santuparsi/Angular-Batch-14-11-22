import { Component, OnInit } from '@angular/core';
import { Item } from 'src/app/Models/item';
import { AdminService } from 'src/app/Services/admin.service';

@Component({
  selector: 'app-updateitem',
  templateUrl: './updateitem.component.html',
  styleUrls: ['./updateitem.component.css']
})
export class UpdateitemComponent implements OnInit {

item:Item;
  constructor(private adminService:AdminService) {
  this.item=new Item();
  let itemId=localStorage.ItemId;
  console.log(itemId);
  this.adminService.GetItemById(itemId).subscribe(response=>{
      this.item=response
      console.log(this.item);
  });
   }
   ngOnInit(){}

  Edit() {
    console.log(this.item);
    this.adminService.UpdateItem(this.item).subscribe(response=>{

    });
  }
}

