import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
let PizzaService = class PizzaService {
    constructor(http) {
        this.http = http;
    }
    getPizzas() {
        return this.http.get("http://localhost:51105/api/Serve");
    }
};
PizzaService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], PizzaService);
export { PizzaService };
//# sourceMappingURL=data.servpizza.js.map