using Studio27SalonOfBeauty.Models.EntityModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace Studio27SalonOfBeauty.Models.ViewModels.Products
{
    public class EditProductViewModel
    {
        public int Id { get; set; }
     
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Description { get; set; }
        //public ProductCategory Category { get; set; }
    }
}
