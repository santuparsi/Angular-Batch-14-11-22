import { Component } from '@angular/core';
import { CalculateService } from '../Shared/calculate.service';
@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class Demo1Component {
  n1:number=0;
  n2:number=0;
  result?:number;
  constructor(private calcService:CalculateService)
  {

  }
  //component-methods
  Addition()
  {
    this.result=this.calcService.Add(this.n1,this.n2);
  }

}
