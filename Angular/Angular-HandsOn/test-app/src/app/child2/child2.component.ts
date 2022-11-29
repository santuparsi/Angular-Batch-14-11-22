import { Component, OnInit, Output,EventEmitter} from '@angular/core';


@Component({
  selector: 'app-child2',
  templateUrl: './child2.component.html',
  styleUrls: ['./child2.component.css']
})
export class Child2Component implements OnInit {
message:string='Message from Children';
@Output() messageEvent=new EventEmitter<string>();
  constructor() { }

  ngOnInit(): void {
  }
  sendMessage()
  {
    this.messageEvent.emit(this.message);
  }

}
