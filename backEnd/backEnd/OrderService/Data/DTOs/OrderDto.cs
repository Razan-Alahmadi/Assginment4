namespace OrderService.Data.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public List<OrderItemDto> Items { get; set; } = new List<OrderItemDto>();
        public decimal TotalPrice { get; set; }
    }

}
