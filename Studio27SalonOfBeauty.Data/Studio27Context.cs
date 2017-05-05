using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Studio27SalonOfBeauty.Models.EntityModels;


namespace Studio27SalonOfBeauty.Data
{
    public class Studio27Context : IdentityDbContext<ApplicationUser>
    {
        public Studio27Context()
            : base("name=Studio27Context", throwIfV1Schema: false)
        {

        }

        public DbSet<Employee> Team { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubProduct> SubProducts { get; set; }

        public static Studio27Context Create()
        {
            return new Studio27Context();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
             .Property(c => c.Id);

            modelBuilder.Entity<SubProduct>().ToTable("SubProducts");


            //modelBuilder.Entity<CareLine>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("CareLineProducts");
            //});

            //modelBuilder.Entity<SoPure>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("SoPureProducts");
            //});
            //modelBuilder.Entity<Man>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("ManProducts");
            //});
            //modelBuilder.Entity<CareLine>().ToTable("CareLineProducts");
            //modelBuilder.Entity<SoPure>().ToTable("SoPureProducts");
            base.OnModelCreating(modelBuilder);
        }

        //public System.Collections.Generic.IEnumerable<Studio27SalonOfBeauty.Areas.Admin.Models.CustomersViewModel> GetCustomers()
        //{
        //    throw new NotImplementedException();
        //}

        //public System.Collections.Generic.IEnumerable<Studio27SalonOfBeauty.Areas.Admin.Models.CustomersViewModel> GetCsutomers()
        //{
        //    throw new NotImplementedException();
        //}

        //public System.Data.Entity.DbSet<Studio27SalonOfBeauty.Models.BindingModels.AddProductBinding> AddProductBindings { get; set; }


    }
}