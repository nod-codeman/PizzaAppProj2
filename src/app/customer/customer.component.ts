import { Component, OnInit, Input} from '@angular/core';

import { Pizza} from '../pizza'





@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.scss']
})


export class CustomerComponent implements OnInit{

  @Input() pizza: Pizza
  @Input() pizzaImageUrl = 'dist/assets/garden-veggie-pizza.ico';

  constructor(){
   
      
  }

  ngOnInit(){

  }

  
}

  

