using System.Data.Entity;
namespace OnlinExpressCheckout.Models
{
  public class OnlinExpressCheckoutContext : DbContext
  {
    public OnlinExpressCheckoutContext()
      : base("OnlinExpressCheckout")
    {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<CartItem> ShoppingCartItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
  }
}