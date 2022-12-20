import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators} from '@angular/forms';
import { Item } from 'src/app/Models/item';
import { AdminService } from 'src/app/Services/admin.service';
@Component({
  selector: 'app-additem',
  templateUrl: './additem.component.html',
  styleUrls: ['./additem.component.css']
})
export class AdditemComponent implements OnInit {

  itemForm: FormGroup;
  submitted = false;
item:Item;
  constructor(private formBuilder: FormBuilder,private adminService:AdminService) {
    this.item=new Item();
   }

  ngOnInit() {
      this.itemForm = this.formBuilder.group({
          itemid: ['', Validators.required],
          itemname: ['', [Validators.required,
              Validators.pattern('^[a-zA-Z]{3,6}$')]],
          price: ['', [Validators.required]]
      });
  }

  // convenience getter for easy access to form fields
  get f() { return this.itemForm.controls; }

  onSubmit() {
   // alert('HHi')
      this.submitted = true;
      if (this.itemForm.valid) {
        this.item.itemId=this.itemForm.value["itemid"]
        this.item.itemName=this.itemForm.value["itemname"]
        this.item.price=Number(this.itemForm.value["price"])
        this.adminService.AddItem(this.item).subscribe(response=>{
        },error=>{
          console.log(error);
        })
  }
}

  onReset() {
      this.submitted = false;
      this.itemForm.reset();
  }

}
