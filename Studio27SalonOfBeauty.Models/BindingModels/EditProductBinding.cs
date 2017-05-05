using Studio27SalonOfBeauty.Models.EntityModels.Enums;

namespace Studio27SalonOfBeauty.Models.BindingModels
{
    public class EditProductBinding
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
        public string ProductImage { get; set; }
    }
}
