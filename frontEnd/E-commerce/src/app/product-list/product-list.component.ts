import { Component, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { ProductDto } from '../models/product.dto';
import { loadProducts } from '../store/product/product.actions';
import { selectProducts, selectLoading, selectError } from '../store/product/product.selectors';
import { CommonModule } from '@angular/common';
import { createOrder } from '../store/order/order.actions'; 
import { selectOrderSuccess, selectOrderError } from '../store/order/order.selectors'; 
import { RouterLink } from '@angular/router'; 

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  imports: [CommonModule,RouterLink],
  standalone: true, 
})
export class ProductListComponent implements OnInit {
  products$!: Observable<ProductDto[]>; 
  loading$!: Observable<boolean>; 
  error$!: Observable<any>; 
  orderSuccess$!: Observable<boolean>;
  orderError$!: Observable<any>;

  constructor(private store: Store) {}

  ngOnInit() {
    // Initialize observables in ngOnInit
    this.products$ = this.store.select(selectProducts);
    this.loading$ = this.store.select(selectLoading);
    this.error$ = this.store.select(selectError);

    // Initialize order-related observables
    this.orderSuccess$ = this.store.select(selectOrderSuccess);
    this.orderError$ = this.store.select(selectOrderError);

    // Dispatch action to load products
    this.store.dispatch(loadProducts());
  }

// Method to create an order
createOrder(product: ProductDto): void {
  const orderItem = {
    id: 0, 
    items: [
      {
        productId: product.id,
        productName: product.name,
        quantity: 1, 
        unitPrice: product.price,
      },
    ],
    totalPrice: product.price, 
  };

  // Dispatch the createOrder action
  this.store.dispatch(createOrder({ orderItem }));
}
}