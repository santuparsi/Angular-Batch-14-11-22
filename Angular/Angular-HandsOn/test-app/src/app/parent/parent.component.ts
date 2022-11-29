import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { ChildComponent } from '../child/child.component';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent 
implements AfterViewInit {
@ViewChild(ChildComponent) child:any;
message:string='';
msg=''
  constructor() { }
  ngAfterViewInit(): void {
   this.message=this.child.message;
   this.msg=this.child.Greet();
  }

 

}
