import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { CustomerComponent } from './customer.component';
<<<<<<< HEAD
=======
import {HttpClientModule, HttpClient} from '@angular/common/http';
import {PizzaService} from '../data.servpizza';



>>>>>>> developerBranch



describe('CustomerComponent', () => {
  let component: CustomerComponent;
  let fixture: ComponentFixture<CustomerComponent>;
<<<<<<< HEAD
=======
  let testclient: PizzaService;
  
 

>>>>>>> developerBranch
 

  beforeEach(async(() => {
    TestBed.configureTestingModule({
<<<<<<< HEAD
      declarations: [ CustomerComponent ]
=======
      declarations: [ CustomerComponent ],
      imports: [
        
        HttpClientModule
       
      ],
      providers: [PizzaService]
>>>>>>> developerBranch
     
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

<<<<<<< HEAD
   /** 
  it('should have a Pizza Type', () => {
    const fixture = TestBed.createComponent(CustomerComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.PizzaType).toEqual('Bacon' || 'Salami' || 'Peperroni' || 'Chicken' || 'Cheese' || 'Mushroom')
=======
 /**    
  it('should return Pizzas Type', () => {
 
  const something =testclient.getPizzas();

  
    expect(something).toBeNull();
>>>>>>> developerBranch
  });

  it('should have a Customer Tile', () => {
    const fixture = TestBed.createComponent(CustomerComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.PizzaType).toEqual('Bacon' || 'Salami' || 'Peperroni' || 'Chicken' || 'Cheese' || 'Mushroom')
  });
  */
<<<<<<< HEAD
});
=======

})
>>>>>>> developerBranch
