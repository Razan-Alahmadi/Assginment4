import { createReducer, on } from '@ngrx/store';
import { ProductDto } from '../../models/product.dto';
import { loadProducts, loadProductsSuccess, loadProductsFailure } from './product.actions';

export interface ProductState {
  products: ProductDto[];
  loading: boolean;
  error: any;
}

export const initialState: ProductState = {
  products: [],
  loading: false,
  error: null,
};

export const productReducer = createReducer(
  initialState,
  on(loadProducts, (state) => ({ ...state, loading: true, error: null })),
  on(loadProductsSuccess, (state, { products }) => ({ ...state, products, loading: false })),
  on(loadProductsFailure, (state, { error }) => ({ ...state, error, loading: false }))
);