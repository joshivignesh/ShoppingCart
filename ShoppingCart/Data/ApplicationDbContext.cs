using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ShoppingCart.Models.Product> Product { get; set; } = default!;
        public DbSet<ShoppingCart.Models.Category> Category { get; set; } = default!;
        public DbSet<ShoppingCart.Models.ProductCategory> ProductCategory { get; set; } = default!;
        public DbSet<ShoppingCart.Models.Cart> Cart { get; set; } = default!;
        public DbSet<ShoppingCart.Models.Item> Item { get; set; } = default!;
        public DbSet<ShoppingCart.Models.CartItem> CartItem { get; set; } = default!;
    }
}
