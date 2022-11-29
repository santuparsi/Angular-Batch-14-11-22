import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit {
message='Message from Child Component';
  constructor() { }

  ngOnInit(): void {
  }
  Greet()
  {
    return 'Hello Users';
  }

}
