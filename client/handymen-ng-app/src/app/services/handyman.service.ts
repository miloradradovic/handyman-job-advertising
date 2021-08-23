import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';
import {RegisterDataModel} from '../model/register-data.model';
import {SearchParams} from '../model/search-params';
import {ProfileDataModel} from '../model/profile-data.model';

@Injectable({
  providedIn: 'root'
})
export class HandymanService {

  private headers = new HttpHeaders({'Content-Type': 'application/json'});

  constructor(private http: HttpClient) { }

  register(data: RegisterDataModel): Observable<any> {
    return this.http.post('https://localhost:5001/api/handymen/register',
      data, {headers: this.headers, responseType: 'json'});
  }

  getAllHandymen(): Observable<any> {
    return this.http.get('https://localhost:5001/api/handymen', {headers: this.headers, responseType: 'json'});
  }

  search(searchParams: SearchParams): Observable<any> {
    return this.http.post('https://localhost:5001/api/handymen/search', searchParams, {headers: this.headers, responseType: 'json'});
  }

  getHandymanById(data: number): Observable<any> {
    return this.http.get('https://localhost:5001/api/handymen/get-handyman-by-id/' + data, {headers: this.headers, responseType: 'json'});
  }

  getCurrentHandyman(): Observable<any> {
    return this.http.get('https://localhost:5001/api/handymen/get-current-handyman', {headers: this.headers, responseType: 'json'});
  }

  editProfile(profileData: ProfileDataModel): Observable<any> {
    return this.http.put('https://localhost:5001/api/handymen/edit-profile', profileData, {headers: this.headers, responseType: 'json'});
  }
}
