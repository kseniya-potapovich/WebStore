using Microsoft.EntityFrameworkCore;
using Store.Entities;
using System.Reflection.Metadata;

namespace Store.Data;
public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<CartItem> Carts { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderItem> Items { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .HasMany(e => e.OrderItems)
            .WithOne()
            .HasForeignKey("OrderId")
            .IsRequired();

        /*modelBuilder.Entity<Order>()
           .HasMany(e => e.OrderItems)
           .WithOne()
           .HasForeignKey("OrderId")
           .IsRequired();*/
    }

}
