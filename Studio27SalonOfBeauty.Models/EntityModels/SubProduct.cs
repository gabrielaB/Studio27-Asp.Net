using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio27SalonOfBeauty.Models.EntityModels
{
  
    [Table("SubProducts")]
    public class SubProduct    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product's name is mandatory")]
        [DataType(DataType.Text)]
        [MaxLength(30, ErrorMessage = "Maximum name length is 30 symbols")]
        [MinLength(2, ErrorMessage = "Minimum name length is 2 symbols")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150, ErrorMessage = "Maximum description lenght is 150 symbols")]
        [MinLength(3, ErrorMessage = "Minimum description lenght is 3 symbols")]
        public string Description { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
