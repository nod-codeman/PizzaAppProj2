import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
import { HttpHeaders } from '@angular/common/http';
let PizzaService = class PizzaService {
    constructor(http) {
        this.http = http;
    }
    getPizzas(pizza) {
        return this.http.get("http://localhost:51105/api/Serve", { headers: new HttpHeaders({ 'Accept': 'application/json', 'Content-Type': 'application/json' }) });
    }
};
PizzaService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], PizzaService);
export { PizzaService };
//# sourceMappingURL=data.servpizza.js.map