using Microsoft.EntityFrameworkCore;
using OrderService.Models;
using System.Reflection.Metadata;


namespace OrderService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define one-to-many relationship
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Items)               // One Order has many OrderItems
                .WithOne()                            // Each OrderItem is linked to one Order
                .HasForeignKey(oi => oi.Id)      // The foreign key in OrderItem pointing to Order
                .OnDelete(DeleteBehavior.Cascade);    // delete behavior (Cascade)


            base.OnModelCreating(modelBuilder);


        }
    }
}
