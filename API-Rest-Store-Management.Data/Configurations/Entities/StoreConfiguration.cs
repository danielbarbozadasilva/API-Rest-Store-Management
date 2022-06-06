using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Rest_Store_Management.Data.Configurations.Entities
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasData(
                new Store
                {
                    Id = 1,
                    Name = "Teclado Dell",
                    Address = "Modelo HG132",
                    ProductId = 1
                },
                 new Store
                 {
                     Id = 2,
                     Name = "Teclado Dell",
                     Address = "Modelo HG132",
                     ProductId = 2
                 },
               new Store
               {
                   Id = 3,
                   Name = "Teclado Dell",
                   Address = "Modelo HG132",
                   ProductId = 3
               }
            );
        }
    }
}
