import { Injectable } from '@angular/core';
import { Post } from 'src/app/Models/Models/post';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class PostService {

  constructor(private http:HttpClient) { }
  GetAllPosts():Observable<Post[]>
  {
    return this.http.get<Post[]>('https://jsonplaceholder.typicode.com/posts');
  }
  GetPostById(id:number):Observable<Post>
  {
    return this.http.get('https://jsonplaceholder.typicode.com/posts/'+id);
  }
  AddPost(post:Post):Observable<any>
  {
    return this.http.post('https://jsonplaceholder.typicode.com/posts',post);
  }
  EditPost(post:Post):Observable<any>
  {
    return this.http.put('https://jsonplaceholder.typicode.com/posts',post);
  }
  DeletePostById(id:number):Observable<any>
  {
    return this.http.delete('https://jsonplaceholder.typicode.com/posts/'+id);
  }
}
