import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { TypeOfVehicleResponseModel } from '../modules/typeOfVehicleResponseModel';

@Injectable({
  providedIn: 'root'
})
export class TypeOfVehicleService {
apiUrl= "https://localhost:44348/api/typesofvehicle/getall"
  constructor(private HttpClient:HttpClient) { }
  getTypesOfVehicle() {
    return this.HttpClient.get<TypeOfVehicleResponseModel>(this.apiUrl)
  }
}
