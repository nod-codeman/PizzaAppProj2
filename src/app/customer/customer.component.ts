import { Component, OnInit} from '@angular/core';
import { Pizza } from '../pizza';
import { PizzaService } from '../data.servpizza';




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

    this.Pizzasgetter();
    
  }
  Pizzasgetter(){
  
    this.PizzaService.getPizzas().subscribe(d =>
         d.data = this.pizzas)
         
  
  }
  
}

  

