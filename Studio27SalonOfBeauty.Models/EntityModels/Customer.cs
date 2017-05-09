using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studio27SalonOfBeauty.Models.EntityModels
{
    [Table("Customers")]
    public class Customer
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Username is mandatory")]
        [DataType(DataType.Text)]
        [MaxLength(30, ErrorMessage = "Maximum description lenght is 30 symbols")]
        [MinLength(2, ErrorMessage = "Minimum description lenght is 2 symbols")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Phone number is mandatory"),Phone]
        [DataType(DataType.PhoneNumber)]
        [MinLength(10,ErrorMessage ="Phone number must be at least 10 symbols long")]
        public string PhoneNumber { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
