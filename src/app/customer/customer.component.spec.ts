import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { CustomerComponent } from './customer.component';
import {HttpClientModule, HttpClient} from '@angular/common/http';
import {PizzaService} from '../data.servpizza';






describe('CustomerComponent', () => {
  let component: CustomerComponent;
  let fixture: ComponentFixture<CustomerComponent>;
  let testclient: PizzaService;
  
 

 

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CustomerComponent ],
      imports: [
        
        HttpClientModule
       
      ],
      providers: [PizzaService]
     
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
  it('should return Pizzas Type', () => {
 
  const something =testclient.getPizzas();

  
    expect(something).toBeNull();
  });

  it('should have a Customer Tile', () => {
    const fixture = TestBed.createComponent(CustomerComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.PizzaType).toEqual('Bacon' || 'Salami' || 'Peperroni' || 'Chicken' || 'Cheese' || 'Mushroom')
  });
  */

})
