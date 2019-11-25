"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
exports.__esModule = true;
var core_1 = require("@angular/core");
var pizza_1 = require("./pizza");
var AppComponent = /** @class */ (function () {
    function AppComponent(PizzaService) {
        this.PizzaService = PizzaService;
        this.Title = 'WELCOME';
        this.pizzas = [];
    }
    AppComponent.prototype.showCustomer = function () {
        this.Title = 'Customer';
    };
    AppComponent.prototype.Pizzasgetter = function () {
        var _this = this;
        this.PizzaService.getPizzas().subscribe(function (d) {
            return d.data.forEach(function (item) {
                var p1 = new pizza_1.Pizza();
                p1.Id = item.Id;
                p1.OrderId = item.OrderId;
                p1.PizzaType = item.PizzaType;
                p1.QtyS = item.QtyS;
                _this.pizzas.push(p1);
                var p2 = new pizza_1.Pizza();
                p2.Id = item.Id;
                p2.OrderId = item.OrderId;
                p2.PizzaType = item.PizzaType;
                p2.QtyS = item.QtyS;
                _this.pizzas.push(p2);
                var p3 = new pizza_1.Pizza();
                p3.Id = item.Id;
                p3.OrderId = item.OrderId;
                p3.PizzaType = item.PizzaType;
                p3.QtyS = item.QtyS;
                _this.pizzas.push(p3);
                _this.showCustomer();
            });
        });
    };
    AppComponent = __decorate([
        core_1.Component({
            selector: 'app-root',
            templateUrl: './app.component.html',
            styleUrls: ['./app.component.scss']
        })
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
