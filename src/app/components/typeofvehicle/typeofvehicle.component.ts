import { Component, OnInit } from '@angular/core';
import { TypeOfVehicle } from 'src/app/modules/typeOfVehicle';
import { TypeOfVehicleService } from 'src/app/services/type-of-vehicle.service';

@Component({
  selector: 'app-typeofvehicle',
  templateUrl: './typeofvehicle.component.html',
  styleUrls: ['./typeofvehicle.component.css']
})
export class TypeofvehicleComponent implements OnInit {
typesOfVehicle : TypeOfVehicle[] = [];
  constructor(private typeOfVehicleService: TypeOfVehicleService) { }

  ngOnInit(): void {
    this.getTypesOfVehicle
  }
getTypesOfVehicle() {
  this.typeOfVehicleService.getTypesOfVehicle().subscribe(response=>{
    this.typesOfVehicle=response.data
  })

}
}
