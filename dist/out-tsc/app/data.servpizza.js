import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
<<<<<<< HEAD
=======
import { HttpHeaders } from '@angular/common/http';
>>>>>>> developerBranch
let PizzaService = class PizzaService {
    constructor(http) {
        this.http = http;
    }
<<<<<<< HEAD
    getPizzas() {
        return this.http.get("https://vmanpizza-vmanpizzalive.azurewebsites.net/api/Serve");
=======
    getPizzas(pizza) {
        return this.http.get("http://localhost:51105/api/Serve", { headers: new HttpHeaders({ 'Accept': 'application/json', 'Content-Type': 'application/json' }) });
>>>>>>> developerBranch
    }
};
PizzaService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], PizzaService);
export { PizzaService };
//# sourceMappingURL=data.servpizza.js.map