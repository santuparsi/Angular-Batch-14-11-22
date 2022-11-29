import { Component } from '@angular/core';
import { CalculateService } from '../Shared/calculate.service';
@Component({
  selector: 'app-demo2',
  templateUrl: './demo2.component.html',
  styleUrls: ['./demo2.component.css']
})
export class Demo2Component {
  name:string='';
  result:string='';
constructor(private calcService:CalculateService) {

}
Greeting()
{
  this.result=this.calcService.Greet(this.name);
}
}
