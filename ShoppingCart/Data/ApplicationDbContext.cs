using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Product> Product { get; set; } = default!;
        public DbSet<Models.Category> Category { get; set; } = default!;
        public DbSet<Models.ProductCategory> ProductCategory { get; set; } = default!;
        public DbSet<Models.Cart> Cart { get; set; } = default!;
        public DbSet<Models.Item> Item { get; set; } = default!;
        public DbSet<Models.CartItem> CartItem { get; set; } = default!;
    }
}
