import { Component } from '@angular/core';
import { Pizza } from './serv/pizza';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'PizzaAppProj2';
  NewPizza = new Pizza();


  performUnit() {
    

  }

  getPizza(){
    /**Order.Pizzas */
    
    
    return 'Bacon'
  }
}
