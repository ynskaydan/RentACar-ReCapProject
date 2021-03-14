import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CustomerResponseModel } from '../modules/customerResponseModel';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  apiUrl ="https://localhost:44348/api/customers/getalldto";
  constructor(private HttpClient:HttpClient) { }

  getCustomers(){
    return this.HttpClient.get<CustomerResponseModel>(this.apiUrl);
  }
}
