import { Component } from '@angular/core';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent {
  customer_id:number=4320934;
  customer_name:string='Rohan';
  age:number=21;
  dob:Date=new Date(2000,1,21);
  address:string="Bangalore"
}
