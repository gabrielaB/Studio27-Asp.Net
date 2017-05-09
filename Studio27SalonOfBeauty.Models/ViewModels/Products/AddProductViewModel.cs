using Studio27SalonOfBeauty.Models.EntityModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace Studio27SalonOfBeauty.Models.ViewModels.Products
{
    public class AddProductViewModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Description { get; set; }

        [Required]
        public ProductCategory Category { get; set; }
        public string ProductImage { get; set; }
    }
}
