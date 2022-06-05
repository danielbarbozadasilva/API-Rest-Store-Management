using System.ComponentModel.DataAnnotations;

namespace API_Rest_Store_Management.Core.DTOs
{

    public class CreateStoreDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Name is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Address is Too Long")]
        public string Address { get; set; }

        public int ProductId { get; set; }

    }

    public class UpdateStoreDTO : CreateStoreDTO
    {

    }

    public class StoreDTO : CreateStoreDTO
    {
        public int Id { get; set; }
        public ProductDTO Product { get; set; }
    }
}
