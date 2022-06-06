using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Rest_Store_Management.Data.Configurations.Entities
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Teclado Dell",
                    Description = "Modelo HG132",
                    Price = 101.90,
                    StoreId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Mouse Dell",
                    Description = "Modelo HA212",
                    Price = 59.90,
                    StoreId = 2

                },
                new Product
                {
                    Id = 3,
                    Name = "Monitor Dell",
                    Description = "Modelo ACE12",
                    Price = 345.90,
                    StoreId = 3
                }
            );
        }
    }
}
