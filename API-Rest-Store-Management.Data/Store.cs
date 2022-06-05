using System.ComponentModel.DataAnnotations.Schema;

namespace API_Rest_Store_Management.Data
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
