import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ServComponent } from './serv.component';

describe('ServComponent', () => {
  let component: ServComponent;
  let fixture: ComponentFixture<ServComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ServComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ServComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component.getPizza).toBeTruthy();
  });
});
