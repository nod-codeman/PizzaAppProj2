import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-serv',
  templateUrl: './serv.component.html',
  styleUrls: ['./serv.component.scss']
})
export class ServComponent implements OnInit {
   @Input() pizzatype: string
   @Input('master') mastername: string
  constructor() { }

  ngOnInit() {
  }
   
  
  
}
