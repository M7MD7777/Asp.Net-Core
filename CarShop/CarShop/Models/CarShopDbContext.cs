using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Models
{
    public class CarShopDbContext : IdentityDbContext
    {
        public CarShopDbContext(DbContextOptions<CarShopDbContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Company> Companies { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
