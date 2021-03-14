import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TypeofvehicleComponent } from './typeofvehicle.component';

describe('TypeofvehicleComponent', () => {
  let component: TypeofvehicleComponent;
  let fixture: ComponentFixture<TypeofvehicleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TypeofvehicleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TypeofvehicleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
