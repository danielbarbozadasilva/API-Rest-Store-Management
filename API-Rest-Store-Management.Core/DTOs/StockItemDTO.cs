using API_Rest_Store_Management.Data;
using System.ComponentModel.DataAnnotations;

namespace API_Rest_Store_Management.Core.DTOs
{
    public class CreateStockItemDTO
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int StoreId { get; set; }

        [Required]
        public int Quantity { get; set; }

    }

    public class StockDTO : CreateStockItemDTO
    {
        public int Id { get; set; }
        public ICollection<StockItem> StockItem { get; set; }
    }
}
