import { TestBed } from '@angular/core/testing';

import { TypeOfVehicleService } from './type-of-vehicle.service';

describe('TypeOfVehicleService', () => {
  let service: TypeOfVehicleService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TypeOfVehicleService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
