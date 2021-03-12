import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CarResponseModel } from '../modules/carResponseModel';
@Injectable({
  providedIn: 'root'
})
export class CarService {
apiUrl = 'https://localhost:44309/api/cars/getalldto';
  constructor(private HttpClient:HttpClient) { }

   getCars():Observable<CarResponseModel>{
     return this.HttpClient.get<CarResponseModel>(this.apiUrl);
   }
 
}
