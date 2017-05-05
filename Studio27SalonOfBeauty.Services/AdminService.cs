using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studio27SalonOfBeauty.Models.EntityModels;

namespace Studio27SalonOfBeauty.Services
{
    public class AdminService : Service
    {
        public IEnumerable<Customer> GetCustomers()
        {
            var customers = this.Context.Customers;
            return customers;
        }
    }
}
