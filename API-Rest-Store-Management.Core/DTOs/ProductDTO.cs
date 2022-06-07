using System.ComponentModel.DataAnnotations;

namespace API_Rest_Store_Management.Core.DTOs
{
    public class CreateProductDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Name Is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Description Is Too Long")]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int StoreId { get; set; }
    }

    public class UpdateProductDTO : CreateProductDTO
    {

    }

    public class ProductDTO : CreateProductDTO
    {
        public int Id { get; set; }
        public StoreDTO Store { get; set; }
    }
}
