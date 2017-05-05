using Studio27SalonOfBeauty.Models.EntityModels.Enums;

namespace Studio27SalonOfBeauty.Models.ViewModels.Products
{
    public class AddProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
        public string ProductImage { get; set; }
    }
}
