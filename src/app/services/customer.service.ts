import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CustomerResponseModel } from '../modules/customerResponseModel';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  apiUrl ="https://localhost:44309/api/customers/getall";
  constructor(private HttpClient:HttpClient) { }

  getCustomers(){
    return this.HttpClient.get<CustomerResponseModel>(this.apiUrl);
  }
}
