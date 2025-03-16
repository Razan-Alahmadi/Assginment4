import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { OrderDto } from '../models/order.dto';

@Injectable({
  providedIn: 'root',
})
export class OrderService {
  private apiUrl = 'http://localhost:5013/api/order';

  constructor(private http: HttpClient) {}

  // Method to fetch orders
  getOrders(): Observable<OrderDto[]> {
    return this.http.get<OrderDto[]>(this.apiUrl);
  }

  // Method to create an order
  createOrder(orderItem: OrderDto): Observable<OrderDto> {
    return this.http.post<OrderDto>(this.apiUrl, orderItem);
  }

  
  // Method to delete an order
  deleteOrder(orderId: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${orderId}`);
  }

// Method to update an order
updateOrder(order: OrderDto): Observable<OrderDto> {
  return this.http.put<OrderDto>(`${this.apiUrl}/${order.id}`, order);
}
}