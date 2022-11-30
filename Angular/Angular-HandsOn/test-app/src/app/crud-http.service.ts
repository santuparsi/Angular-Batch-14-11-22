import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError } from 'rxjs/operators';
import { Observable, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CrudHttpService {
  apiUrl: string = 'http://localhost:3000/products';
  headers = new HttpHeaders().set('Content-Type', 'application/json');
  constructor(private http: HttpClient) { }
  // Create
  create(data: any): Observable<any> {
    let API_URL = `${this.apiUrl}`;
    return this.http.post(API_URL, data)

  }
  // Read
  list(): Observable<any> {
    return this.http.get(`${this.apiUrl}`);
  }
  // Update
  update(id: any, data: any): Observable<any> {
    let API_URL = `${this.apiUrl}/${id}`;
    return this.http.put(API_URL, data, { headers: this.headers })

  }

  // Delete
  delete(id: any): Observable<any> {
    var API_URL = `${this.apiUrl}/${id}`;
    return this.http.delete(API_URL)


  }
}
