import { Component } from '@angular/core';

@Component({
  selector: 'app-propery-binding-demo',
  templateUrl: './propery-binding-demo.component.html',
  styleUrls: ['./propery-binding-demo.component.css']
})
export class ProperyBindingDemoComponent {
title:string='Angular Propery Binding Demo';
page_url:string='http://www.google.co.in';
img_path:string='..//../assets/img.jpg'
img_width:number=300;
img_height:number=250;
UrlChange()
{
  this.page_url='http://www.twitter.com';
}
ChangeImage()
{
  this.img_path='..//../assets/img1.jpg';
  this.img_width=400;
  this.img_height=400;
}
}
