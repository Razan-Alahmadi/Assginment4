import { Injectable, inject } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { of } from 'rxjs';
import { catchError, map, mergeMap } from 'rxjs/operators';
import { OrderService } from '../../services/order.service';
import {
  loadOrders,
  loadOrdersSuccess,
  loadOrdersFailure,
  createOrder,
  createOrderSuccess,
  createOrderFailure,
  deleteOrder,
  deleteOrderSuccess,
  deleteOrderFailure,
  updateOrder,
  updateOrderSuccess,
  updateOrderFailure,
} from './order.actions';

@Injectable()
export class OrderEffects {
  private actions$ = inject(Actions);
  private orderService = inject(OrderService);

  // Effect to handle loading orders
  loadOrders$ = createEffect(() =>
    this.actions$.pipe(
      ofType(loadOrders),
      mergeMap(() =>
        this.orderService.getOrders().pipe(
          map((orders) => loadOrdersSuccess({ orders })),
          catchError((error) => of(loadOrdersFailure({ error })))
        )
      )
    )
  );

  // Effect to handle creating an order
  createOrder$ = createEffect(() =>
    this.actions$.pipe(
      ofType(createOrder),
      mergeMap(({ orderItem }) =>
        this.orderService.createOrder(orderItem).pipe(
          map((order) => createOrderSuccess({ order })),
          catchError((error) => of(createOrderFailure({ error })))
        )
      )
    )
  );

  // Effect to handle deleting an order
  deleteOrder$ = createEffect(() =>
    this.actions$.pipe(
      ofType(deleteOrder),
      mergeMap(({ orderId }) =>
        this.orderService.deleteOrder(orderId).pipe(
          map(() => deleteOrderSuccess({ orderId })), 
          catchError((error) => of(deleteOrderFailure({ error })))
        )
      )
    )
  );

  // Effect to handle updating an order
  updateOrder$ = createEffect(() =>
    this.actions$.pipe(
      ofType(updateOrder),
      mergeMap(({ order }) =>
        this.orderService.updateOrder(order).pipe(
          map((updatedOrder) => updateOrderSuccess({ order: updatedOrder })),
          catchError((error) => of(updateOrderFailure({ error })))
        )
      )
    )
  );
}