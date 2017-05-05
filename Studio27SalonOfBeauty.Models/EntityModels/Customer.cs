using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studio27SalonOfBeauty.Models.EntityModels
{
    [Table("Customers")]
    public class Customer
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
