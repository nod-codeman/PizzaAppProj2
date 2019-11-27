import { __decorate } from "tslib";
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CustomerComponent } from './customer/customer.component';
import { HttpClientModule } from '@angular/common/http';
import { PizzaService } from './data.servpizza';
import { Pizza } from './pizza';
<<<<<<< HEAD
import { LoginComponent } from './customer/login/login.component';
import { FormsModule } from '@angular/forms';
=======
>>>>>>> developerBranch
let AppModule = class AppModule {
};
AppModule = __decorate([
    NgModule({
        declarations: [
            AppComponent,
<<<<<<< HEAD
            CustomerComponent,
            LoginComponent
=======
            CustomerComponent
>>>>>>> developerBranch
        ],
        imports: [
            BrowserModule,
            AppRoutingModule,
<<<<<<< HEAD
            HttpClientModule,
            FormsModule
=======
            HttpClientModule
>>>>>>> developerBranch
        ],
        providers: [PizzaService, Pizza],
        bootstrap: [AppComponent]
    })
], AppModule);
export { AppModule };
//# sourceMappingURL=app.module.js.map