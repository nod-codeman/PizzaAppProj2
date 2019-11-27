import { Component, OnInit} from '@angular/core';
<<<<<<< HEAD
import { Pizza } from '../pizza';
import { PizzaService } from '../data.servpizza';
=======
import { PizzaService } from '../data.servpizza';
import { Pizza } from '../pizza';


>>>>>>> developerBranch




@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.scss']
})


export class CustomerComponent implements OnInit{
<<<<<<< HEAD
  
=======
 
>>>>>>> developerBranch
  Runit = this.Pizzasgetter();
  
  pizzas: Pizza[] = [];

  pizzaImageUrl = 'dist/assets/garden-veggie-pizza.ico';

<<<<<<< HEAD
=======
 

>>>>>>> developerBranch
  constructor(private PizzaService: PizzaService){

  

  }
<<<<<<< HEAD

  ngOnInit(){

    this.Pizzasgetter();
    
  }
  Pizzasgetter(){
  
    this.PizzaService.getPizzas().subscribe(d =>
         d.data = this.pizzas)
         
=======
ngOnInit(){
  
    
    

}
  public Pizzasgetter(){
    
    this.PizzaService.getPizzas(this.pizzas).subscribe(d =>
      this.pizzas = d.data)
      
>>>>>>> developerBranch
  
  }
  
}

<<<<<<< HEAD
  

=======
>>>>>>> developerBranch
