import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CustomerComponent} from './customer/customer.component'
import { OrderComponent} from './order/order.component'


const routes: Routes = [{path: 'customer', component: CustomerComponent },
                          {path: 'order', component: OrderComponent }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
