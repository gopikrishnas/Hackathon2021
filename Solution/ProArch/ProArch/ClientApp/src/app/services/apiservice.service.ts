import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CrickInsight } from '../models/crick-insight';

@Injectable({
  providedIn: 'root'
})
export class ApiserviceService {
  public headers: HttpHeaders = new HttpHeaders({
    'Content-Type': 'application/json',
    Accept: 'application/json'
  });

  api_url = 'https://localhost:44398/api/';
  constructor(private readonly http: HttpClient) {
  }

  getInsights(type:number) {    
     return this.http 
        .get<CrickInsight[]>(this.api_url+`cricket/` + type, { headers: this.headers })

  }

}


