using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Rest_Store_Management.Data.Configurations.Entities
{
    public class StockItemConfiguration : IEntityTypeConfiguration<StockItem>
    {
        public void Configure(EntityTypeBuilder<StockItem> builder)
        {
            builder.HasData(
                new StockItem
                {
                    Id = 1,
                    Quantity = 100,
                    StoreId = 1,
                    ProductId = 1
                },
                 new StockItem
                 {
                     Id = 2,
                     Quantity = 50,
                     StoreId = 2,
                     ProductId = 2
                 },
               new StockItem
               {
                   Id = 3,
                   Quantity = 150,
                   StoreId = 3,
                   ProductId = 3
               }
            );
        }
    }
}
