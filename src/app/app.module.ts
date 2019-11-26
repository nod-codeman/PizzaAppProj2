import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CustomerComponent } from './customer/customer.component';

import {HttpClientModule} from '@angular/common/http';
import {PizzaService} from './data.servpizza';

import {Pizza} from './pizza';
import { LoginComponent } from './customer/login/login.component';

import {FormsModule} from '@angular/forms';







@NgModule({
  declarations: [
    AppComponent,
    CustomerComponent,
    LoginComponent
   
  
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
    
  ],
  providers: [PizzaService, Pizza],
  bootstrap: [AppComponent]
})
export class AppModule { }
