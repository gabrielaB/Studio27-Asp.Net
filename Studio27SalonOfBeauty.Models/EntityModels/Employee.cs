using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio27SalonOfBeauty.Models.EntityModels
{
    [Table("Team")]
    public class Employee
    {
        public int Id { get; set; }
     
        public virtual ApplicationUser User { get; set; }
    }
}
