import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ColorResponseModel } from '../modules/colorResponseModel';

@Injectable({
  providedIn: 'root'
})
export class ColorService {
  apiUrl = 'https://localhost:44348/api/colors/getall';
  constructor(private HttpClient:HttpClient) { }

  getColors() {
    return this.HttpClient.get<ColorResponseModel>(this.apiUrl);
  }
}
