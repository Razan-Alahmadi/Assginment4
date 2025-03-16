import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';
import { routes } from './app.routes';
import { provideStore } from '@ngrx/store';
import { provideEffects } from '@ngrx/effects';
import { productReducer } from './store/product/product.reducer';
import { ProductEffects } from './store/product/product.effects';
import { orderReducer } from './store/order/order.reducer';
import { OrderEffects } from './store/order/order.effects';
import { provideHttpClient, withFetch } from '@angular/common/http';

export const appConfig: ApplicationConfig = {
  providers: [
    provideRouter(routes),
    provideStore({ product: productReducer, order: orderReducer }), 
    provideEffects([ProductEffects, OrderEffects]), 
    provideHttpClient(withFetch()), 
  ],
};