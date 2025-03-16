import { createAction, props } from '@ngrx/store';
import { OrderDto } from '../../models/order.dto';

// Actions for loading orders
export const loadOrders = createAction('[Order] Load Orders');
export const loadOrdersSuccess = createAction(
  '[Order] Load Orders Success',
  props<{ orders: OrderDto[] }>()
);
export const loadOrdersFailure = createAction(
  '[Order] Load Orders Failure',
  props<{ error: any }>()
);

// Actions for creating an order
export const createOrder = createAction(
  '[Order] Create Order',
  props<{ orderItem: OrderDto }>() 
);

export const createOrderSuccess = createAction(
  '[Order] Create Order Success',
  props<{ order: OrderDto }>()
);

export const createOrderFailure = createAction(
  '[Order] Create Order Failure',
  props<{ error: any }>()
);

// Actions for deleting an order
export const deleteOrder = createAction(
  '[Order] Delete Order',
  props<{ orderId: number }>() 
);
export const deleteOrderSuccess = createAction(
  '[Order] Delete Order Success',
  props<{ orderId: number }>() 
);
export const deleteOrderFailure = createAction(
  '[Order] Delete Order Failure',
  props<{ error: any }>()
);


// Actions for updating an order
export const updateOrder = createAction(
  '[Order] Update Order',
  props<{ order: OrderDto }>() 
);
export const updateOrderSuccess = createAction(
  '[Order] Update Order Success',
  props<{ order: OrderDto }>() 
);
export const updateOrderFailure = createAction(
  '[Order] Update Order Failure',
  props<{ error: any }>()
);