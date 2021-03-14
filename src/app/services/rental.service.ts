import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { RentalResponseModel } from '../modules/rentalResponseModel';

@Injectable({
  providedIn: 'root'
})
export class RentalService {
apiUrl = "https://localhost:44348/api/rentals/getall"
  constructor(private HttpClient:HttpClient) { }
  getRentals(){
    return this.HttpClient.get<RentalResponseModel>(this.apiUrl)
  }
}
