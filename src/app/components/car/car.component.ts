import { Component, OnInit } from '@angular/core';
import { Car } from 'src/app/modules/car';
import {CarResponseModel} from 'src/app/modules/carResponseModel';
import { CarService } from 'src/app/services/car.service';




@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css']
})
export class CarComponent implements OnInit {
   cars : Car[] = [];
  // car1:Car ={carId:1,colorName:"Red",dailyPrice:600,typeOfVehicleName:"SUV",brandName:"BMW",modelYear:2015}
  // car2:Car ={carId:2,colorName:"Black",dailyPrice:100,typeOfVehicleName:"Sedan",brandName:"Renault",modelYear:2005}
  // car3:Car ={carId:3,colorName:"Grey",dailyPrice:60,typeOfVehicleName:"Commercial Vehicle",brandName:"Fiat",modelYear:2009}

  // cars = [this.car1,this.car2,this.car3]
  constructor(private carService:CarService) { }

  ngOnInit(): void {
    this.getCars();
  }
getCars(){
  this.carService.getCars().subscribe(response => {
    this.cars = response.data
  });
}
}
