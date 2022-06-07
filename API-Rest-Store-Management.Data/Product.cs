using System.ComponentModel.DataAnnotations.Schema;

namespace API_Rest_Store_Management.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        [ForeignKey(nameof(Store))]
        public int StoreId { get; set; }
        public ICollection<Store> Store { get; set; }
    }
}
