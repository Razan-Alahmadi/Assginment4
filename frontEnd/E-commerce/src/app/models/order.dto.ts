export interface OrderDto {
    id: number;
    items: OrderItemDto[];
    totalPrice: number;
  }
  
 
  export interface OrderItemDto {
    productId: number;
    productName: string;
    quantity: number;
    unitPrice: number;
    editing?: boolean; 
    originalQuantity?: number; 
  }


  