
import { Routes } from '@angular/router';
import { ProductListComponent } from './product-list/product-list.component';
import { OrderPlaceComponent } from './order-place/order-place.component';

export const routes: Routes = [
  { path: '', component: ProductListComponent }, 
  { path: 'orders', component: OrderPlaceComponent }, 
];