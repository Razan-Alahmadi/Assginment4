import { createReducer, on } from '@ngrx/store';
import { OrderDto } from '../../models/order.dto';
import {
  loadOrders, loadOrdersSuccess, loadOrdersFailure, createOrderSuccess, createOrderFailure, deleteOrderSuccess, deleteOrderFailure, updateOrderSuccess,
  updateOrderFailure,
} from './order.actions';

export interface OrderState {
  orders: OrderDto[];
  loading: boolean;
  error: any;
}

export const initialState: OrderState = {
  orders: [],
  loading: false,
  error: null,
};

export const orderReducer = createReducer(
  initialState,
  on(loadOrders, (state) => ({ ...state, loading: true, error: null })),
  on(loadOrdersSuccess, (state, { orders }) => ({ ...state, orders, loading: false })),
  on(loadOrdersFailure, (state, { error }) => ({ ...state, error, loading: false })),
  on(createOrderSuccess, (state, { order }) => ({
    ...state,
    orders: [...state.orders, order], 
    loading: false,
  })),
  on(createOrderFailure, (state, { error }) => ({
    ...state,
    error,
    loading: false,
  })),

  // Handle deleting an order
  on(deleteOrderSuccess, (state, { orderId }) => ({
    ...state,
    orders: state.orders.filter((order) => order.id !== orderId), 
    loading: false,
  })),


  on(deleteOrderFailure, (state, { error }) => ({
    ...state,
    error,
    loading: false,
  })),

  // Handle updating an order
  on(updateOrderSuccess, (state, { order }) => ({
    ...state,
    orders: state.orders.map((o) => (o.id === order.id ? order : o)), 
    loading: false,
  })),
  on(updateOrderFailure, (state, { error }) => ({
    ...state,
    error,
    loading: false,
  }))
);