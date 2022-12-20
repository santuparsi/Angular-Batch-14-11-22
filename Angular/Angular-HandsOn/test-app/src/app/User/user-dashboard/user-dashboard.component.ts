import { Component, OnInit } from '@angular/core';
import { Item } from 'src/app/Models/item';
import { Payment } from 'src/app/Models/payment';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-user-dashboard',
  templateUrl: './user-dashboard.component.html',
  styleUrls: ['./user-dashboard.component.css']
})
export class UserDashboardComponent implements OnInit {
itemName:string;
item:Item;
payment:Payment;
visible=false;
  constructor(private userService:UserService) {
    this.item=new Item();
   }

  ngOnInit(): void {
  }

SearchItem()
{
  this.userService.Search(this.itemName).subscribe(response=>{
    this.item=response;
    console.log(this.item);
    this.visible=true;
  })
}
Purchase()
{
  this.payment=new  Payment();
  this.payment.amount=this.item.price;
  this.payment.itemId=this.item.itemId;
  this.payment.userId=localStorage.userId;
  console.log(this.payment);
  this.userService.Buy(this.payment).subscribe(response=>{
    
  })

}
}
