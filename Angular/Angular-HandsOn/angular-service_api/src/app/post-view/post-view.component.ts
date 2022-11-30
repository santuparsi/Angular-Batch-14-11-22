import { Component } from '@angular/core';
import { Post } from '../Models/Models/post';
import { PostService } from '../Shared/Shared/post.service';
@Component({
  selector: 'app-post-view',
  templateUrl: './post-view.component.html',
  styleUrls: ['./post-view.component.css']
})
export class PostViewComponent {
  posts:Post[]=[];
constructor(private postService:PostService) {
this.postService.GetAllPosts().subscribe(response=>{
  this.posts=response;
  console.log(this.posts);
})

}

}
