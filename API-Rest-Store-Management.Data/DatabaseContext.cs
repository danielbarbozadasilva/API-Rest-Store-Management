using API_Rest_Store_Management.Data.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API_Rest_Store_Management.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new StoreConfiguration());
            builder.ApplyConfiguration(new StockItemConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
