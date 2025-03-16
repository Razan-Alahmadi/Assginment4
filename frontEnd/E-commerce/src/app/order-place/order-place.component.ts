import { Component, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { loadOrders } from '../store/order/order.actions';
import { selectOrders, selectLoading, selectError } from '../store/order/order.selectors';
import { deleteOrder, updateOrder } from '../store/order/order.actions';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { RouterModule, Router } from '@angular/router';
import { OrderDto } from '../models/order.dto';
import { OrderItemDto } from '../models/order.dto';

@Component({
  selector: 'app-order-place',
  standalone: true,
  imports: [FormsModule, CommonModule, RouterModule],
  templateUrl: './order-place.component.html',
  styleUrls: ['./order-place.component.css'],
})
export class OrderPlaceComponent implements OnInit {
  orders$!: Observable<OrderDto[]>;
  loading$!: Observable<boolean>;
  error$!: Observable<any>;

  constructor(private store: Store, private router: Router) {}

  ngOnInit(): void {
    this.orders$ = this.store.select(selectOrders);
    this.loading$ = this.store.select(selectLoading);
    this.error$ = this.store.select(selectError);

    this.store.dispatch(loadOrders());
  }

  // Method to go back
  goBack(): void {
    this.router.navigate(['/']);
  }

  // Method to delete an order
  deleteOrder(orderId: number): void {
    if (confirm('Are you sure you want to delete this order?')) {
      this.store.dispatch(deleteOrder({ orderId }));
    }
  }

  // Method to start editing an item
  startEdit(order: OrderDto, item: OrderItemDto): void {
    const editedItem = { 
      ...item, 
      editing: true, 
      originalQuantity: item.quantity || 1,
    };
    const updatedOrder = {
      ...order,
      items: order.items.map((i) =>
        i.productId === item.productId ? this.stripNonDtoProperties(editedItem) : this.stripNonDtoProperties(i)
      ),
    };

    this.store.dispatch(updateOrder({ order: updatedOrder }));
  }

  // Method to cancel editing an item
  cancelEdit(order: OrderDto, item: OrderItemDto): void {
    const updatedItem = { 
      ...item, 
      editing: false, 
      quantity: item.originalQuantity || item.quantity || 1,
    };
    const updatedOrder = {
      ...order,
      items: order.items.map((i) =>
        i.productId === item.productId ? this.stripNonDtoProperties(updatedItem) : this.stripNonDtoProperties(i)
      ),
    };

    this.store.dispatch(updateOrder({ order: updatedOrder }));
  }

  // Method to save the edited item
  saveOrderItem(order: OrderDto, item: OrderItemDto): void {
    const updatedItem = { 
      ...item, 
      editing: false, 
      quantity: item.quantity || 1,
    };
    const updatedOrder = {
      ...order,
      items: order.items.map((i) =>
        i.productId === item.productId ? this.stripNonDtoProperties(updatedItem) : this.stripNonDtoProperties(i)
      ),
    };

    this.store.dispatch(updateOrder({ order: updatedOrder }));
  }

  private stripNonDtoProperties(item: OrderItemDto): OrderItemDto {
    const { editing, originalQuantity, ...rest } = item;
    return rest;
  }
}
