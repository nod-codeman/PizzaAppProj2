import { __decorate } from "tslib";
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
<<<<<<< HEAD
import { LoginComponent } from './customer/login/login.component';
const routes = [{ path: 'customer', component: LoginComponent }];
=======
import { CustomerComponent } from './customer/customer.component';
const routes = [{ path: 'customer', component: CustomerComponent }];
>>>>>>> developerBranch
let AppRoutingModule = class AppRoutingModule {
};
AppRoutingModule = __decorate([
    NgModule({
        imports: [RouterModule.forRoot(routes)],
        exports: [RouterModule]
    })
], AppRoutingModule);
export { AppRoutingModule };
//# sourceMappingURL=app-routing.module.js.map