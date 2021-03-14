import { ResponseModel } from "./responseModel";
import { TypeOfVehicle } from "./typeOfVehicle";

export interface TypeOfVehicleResponseModel extends ResponseModel {
    data:TypeOfVehicle[];
}