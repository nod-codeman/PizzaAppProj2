"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
exports.__esModule = true;
var core_1 = require("@angular/core");
<<<<<<< HEAD
<<<<<<< HEAD:src/app/data.servpizza.js
var PizzaService = /** @class */ (function () {
    function PizzaService(http) {
        this.http = http;
=======
var AppComponent = /** @class */ (function () {
    function AppComponent() {
>>>>>>> developerBranch:src/app/app.component.js
    }
    PizzaService.prototype.getPizzas = function () {
        return this.http.get("https://http://localhost:51105/api/Serve");
=======
var http_1 = require("@angular/common/http");
var PizzaService = /** @class */ (function () {
    function PizzaService(http) {
        this.http = http;
    }
    PizzaService.prototype.getPizzas = function (pizzas) {
        return this.http.get("http://localhost:51105/api/Serve", { headers: new http_1.HttpHeaders({ 'Accept': 'application/json', 'Content-Type': 'application/json' }) });
>>>>>>> developerBranch
    };
    PizzaService = __decorate([
        core_1.Injectable({
            providedIn: 'root'
        })
    ], PizzaService);
    return PizzaService;
}());
exports.PizzaService = PizzaService;
