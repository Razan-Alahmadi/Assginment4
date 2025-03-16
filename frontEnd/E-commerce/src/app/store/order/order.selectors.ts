import { createFeatureSelector, createSelector } from '@ngrx/store';
import { OrderState } from './order.reducer';

export const selectOrderState = createFeatureSelector<OrderState>('order');

export const selectOrders = createSelector(
  selectOrderState,
  (state) => state.orders
);

export const selectLoading = createSelector(
  selectOrderState,
  (state) => state.loading
);

export const selectError = createSelector(
  selectOrderState,
  (state) => state.error
);

export const selectOrderSuccess = createSelector(
  selectOrderState,
  (state) => !state.loading && !state.error
);

export const selectOrderError = createSelector(
  selectOrderState,
  (state) => state.error
);