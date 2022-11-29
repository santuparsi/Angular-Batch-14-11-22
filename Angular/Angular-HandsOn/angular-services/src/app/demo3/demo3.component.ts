import { Component } from '@angular/core';
import { HelloService } from '../Shared/hello.service';

@Component({
  selector: 'app-demo3',
  templateUrl: './demo3.component.html',
  styleUrls: ['./demo3.component.css'],
  providers:[HelloService]
})
export class Demo3Component {
constructor(private service:HelloService) {

  console.log(this.service.HelloUser());
}

}
