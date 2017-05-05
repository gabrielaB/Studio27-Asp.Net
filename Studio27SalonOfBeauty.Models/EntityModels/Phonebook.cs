using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio27SalonOfBeauty.Models.EntityModels
{
    public class Phonebook
    {
        public int Id { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
