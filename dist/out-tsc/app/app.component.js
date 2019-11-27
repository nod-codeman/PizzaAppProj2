import { __decorate } from "tslib";
import { Component } from '@angular/core';
<<<<<<< HEAD
let AppComponent = class AppComponent {
    constructor() {
=======
import { Pizza } from './pizza';
let AppComponent = class AppComponent {
    constructor(PizzaService) {
        this.PizzaService = PizzaService;
        this.Title = 'WELCOME';
        this.pizzas = [];
    }
    showCustomer() {
        this.Title = 'Customer';
    }
    Pizzasgetter() {
        this.PizzaService.getPizzas(new Pizza).subscribe(d => d.data.forEach((item) => {
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
            this.showCustomer();
        }));
>>>>>>> developerBranch
    }
};
AppComponent = __decorate([
    Component({
        selector: 'app-root',
        templateUrl: './app.component.html',
        styleUrls: ['./app.component.scss']
    })
], AppComponent);
export { AppComponent };
//# sourceMappingURL=app.component.js.map