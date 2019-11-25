import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { CustomerComponent } from './customer.component';



describe('CustomerComponent', () => {
  let component: CustomerComponent;
  let fixture: ComponentFixture<CustomerComponent>;
 

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CustomerComponent ]
     
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CustomerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

   /** 
  it('should have a Pizza Type', () => {
    const fixture = TestBed.createComponent(CustomerComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.PizzaType).toEqual('Bacon' || 'Salami' || 'Peperroni' || 'Chicken' || 'Cheese' || 'Mushroom')
  });

  it('should have a Customer Tile', () => {
    const fixture = TestBed.createComponent(CustomerComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.PizzaType).toEqual('Bacon' || 'Salami' || 'Peperroni' || 'Chicken' || 'Cheese' || 'Mushroom')
  });
  */
});
