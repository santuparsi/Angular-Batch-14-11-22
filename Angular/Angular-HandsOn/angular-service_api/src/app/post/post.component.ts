import { Component } from '@angular/core';
import { Post } from '../Models/Models/post';
import { PostService } from '../Shared/Shared/post.service';
import { ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent {
  post: Post;
  id:number=0;
  constructor(private postService: PostService,private active:ActivatedRoute) {
    this.active.params.subscribe(p=>this.id=p['id']);
    this.post = new Post();
    {
      this.postService.GetPostById(this.id).subscribe(response => {
        this.post = response;
        console.log(this.post);
      })
    }
  }
}
