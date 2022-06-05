using System.ComponentModel.DataAnnotations.Schema;

namespace API_Rest_Store_Management.Data
{
    public class StockItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        [ForeignKey(nameof(Store))]
        public int StoreId { get; set; }
    }
}
