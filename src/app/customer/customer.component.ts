import { Component, OnInit} from '@angular/core';
import { PizzaService } from '../data.servpizza';
import { Pizza } from '../pizza';






@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.scss']
})


export class CustomerComponent implements OnInit{
 
  Runit = this.Pizzasgetter();
  
  pizzas: Pizza[] = [];

  pizzaImageUrl = 'dist/assets/garden-veggie-pizza.ico';

 

  constructor(private PizzaService: PizzaService){

  

  }
ngOnInit(){
  
    
    

}
  public Pizzasgetter(){
    
    this.PizzaService.getPizzas(this.pizzas).subscribe(d =>
      this.pizzas = d.data)
      
  
  }
  
}

