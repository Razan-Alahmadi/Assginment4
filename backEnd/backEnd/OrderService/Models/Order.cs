using System.ComponentModel.DataAnnotations;
    
namespace OrderService.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public decimal TotalPrice { get; set; }
    }

}
