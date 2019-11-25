import { __decorate } from "tslib";
import { Component, Input } from '@angular/core';
let CustomerComponent = class CustomerComponent {
    constructor() {
        this.pizzaImageUrl = 'dist/assets/garden-veggie-pizza.ico';
    }
    ngOnInit() {
    }
};
__decorate([
    Input()
], CustomerComponent.prototype, "pizza", void 0);
__decorate([
    Input()
], CustomerComponent.prototype, "pizzaImageUrl", void 0);
CustomerComponent = __decorate([
    Component({
        selector: 'app-customer',
        templateUrl: './customer.component.html',
        styleUrls: ['./customer.component.scss']
    })
], CustomerComponent);
export { CustomerComponent };
//# sourceMappingURL=customer.component.js.map