import { Component, OnInit} from '@angular/core';
import { Pizza } from '../pizza';
import { PizzaService } from '../data.servpizza';




@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.scss']
})


export class CustomerComponent implements OnInit{
 
  pizzas: Pizza [] = []
  pizzaImageUrl = 'dist/assets/garden-veggie-pizza.ico';

  constructor(private PizzaService: PizzaService){

  

  }

  ngOnInit(){

    this.Pizzasgetter();
    
  }
  Pizzasgetter(){
  
    this.PizzaService.getPizzas().subscribe(d =>
         d.data.forEach((item) => {
         var p1 = new Pizza();
         p1.Id = item.Id;
         p1.OrderId = item.OrderId;
         p1.PizzaType = item.PizzaType;
         p1.QtyS = item.QtyS;
         this.pizzas.push(p1);
  
         var p2 = new Pizza();
         p2.Id = item.Id;
         p2.OrderId = item.OrderId;
         p2.PizzaType = item.PizzaType;
         p2.QtyS = item.QtyS;
         this.pizzas.push(p2);
  
         var p3 = new Pizza();
         p3.Id = item.Id;
         p3.OrderId = item.OrderId;
         p3.PizzaType = item.PizzaType;
         p3.QtyS = item.QtyS;
         this.pizzas.push(p3);
  
  },))}
  
}

  

