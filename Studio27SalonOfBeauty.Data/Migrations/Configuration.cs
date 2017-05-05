using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Studio27SalonOfBeauty.Models.EntityModels;
using Studio27SalonOfBeauty.Models.EntityModels.Enums;


namespace Studio27SalonOfBeauty.Data.Migrations
{

    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Studio27SalonOfBeauty.Data.Studio27Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(Studio27SalonOfBeauty.Data.Studio27Context context)
        {
            if (!context.Roles.Any(role => role.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };
                manager.Create(role);
            }
            if (!context.Roles.Any(role => role.Name == "Customer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Customer" };
                manager.Create(role);
            }

            if (!(context.Users.Any(u => u.UserName == "admin@admin.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { Name = "Admin", UserName = "admin@admin.com", PhoneNumber = "0797697898",Email= "admin@admin.com" };
                var userResult = userManager.Create(userToInsert, "Password@123");
                if (userResult.Succeeded)
                {

                    var result = userManager.AddToRole(userToInsert.Id, "Admin");

                }


            }


            context.Products.AddOrUpdate(x => x.Name,
                new Product()
                {

                    Name = "Vital Nutrition",
                    Description = "За суха шуплеста и увредена коса",
                    Category = ProductCategory.CareLine,
                    ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/vital-nutrition.jpg")

                },
                new Product()
                {

                    Name = "Sation Oil",
                    Description = "Интензивно подхранващи",
                    Category = ProductCategory.CareLine,
                    ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/SatinOil.jpg")

                },
            new Product()
            {
                Name = "Keratin Smooting",
                Description = "Продукти с активен кератин",
                Category = ProductCategory.CareLine,
                ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/KeratinSmoothing.jpg")
            },
              new Product()
              {

                  Name = "Keratin Curl",
                  Description = "За къдрава коса с кератиин",
                  Category = ProductCategory.CareLine,
                  ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/KeratinCurl.jpg")

              },
                new Product()
                {

                    Name = "Color Care",
                    Description = "За боядисана коса",
                    Category = ProductCategory.CareLine,
                    ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/ColorCare.jpg")

                },
                  new Product()
                  {

                      Name = "Sun Sublime",
                      Description = "Слънчева серия",
                      Category = ProductCategory.CareLine,
                      ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/SunSublime.jpg")

                  },
            new Product()
            {
                Name = "Absolute Volume",
                Description = "За супер обем",
                Category = ProductCategory.CareLine,
                ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/AbsoluteVolume.jpg")

            },
            new Product()
            {
                Name = "Ultimate Control",
                Description = "Анти-фриз ефект",
                Category = ProductCategory.CareLine,
                ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/ul.jpg")

            },
             new Product()
             {
                 Name = "Fortify",
                 Description = "Против косопад",
                 Category = ProductCategory.Man,
                 ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/manFortify.jpg")

             },
              new Product()
              {
                  Name = "Hidrate",
                  Description = "Хидратация",
                  Category = ProductCategory.Man,
                  ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/manHidrate.jpg")
              },
               new Product()
               {
                   Name = "Styling",
                   Description = "Стилизацаия",
                   Category = ProductCategory.Man,
                   ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/manStyiling.jpg")

               },
                new Product()
                {
                    Name = "Calming",
                    Description = "Против пърхот и чувствителен скалп",
                    Category = ProductCategory.SoPure,
                    ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/Calming.jpg")

                },
                 new Product()
                 {
                     Name = "Energizing",
                     Description = "Против косопад",
                     Category = ProductCategory.SoPure,
                     ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/SoPureProtivKosopad.jpg")

                 },
                  new Product()
                  {
                      Name = "Recover",
                      Description = "За изтощена коса",
                      Category = ProductCategory.SoPure,
                      ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/SoPureRecover.jpg")

                  },
                   new Product()
                   {
                       Name = "Morrocan Argan oil",
                       Description = "Чисто арганово масло",
                       Category = ProductCategory.SoPure,
                       ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/SoPureMaroccanArganOil.jpg")

                   },
                    new Product()
                    {
                        Name = "Moisturizing",
                        Description = "Хидратиращи",
                        Category = ProductCategory.SoPure,
                        ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/SoPureRecover.jpg")

                    },
                   new Product()
                   {
                       Name = "Color Care",
                       Description = "Грижа за боядисана коса",
                       Category = ProductCategory.SoPure,
                       ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/SoPureColorCare.jpg")

                   });
            //context.SubProducts.AddOrUpdate(x => x.Name,
            //        new SubProduct()
            //        {
            //            Name = "Shampoon",
            //            Description = "For dry hair",
            //           //ProductImage = Product.SetImage(@"C:/Users/User/Documents/Visual Studio 2015/Projects/Studio27SalonOfBeauty/Studio27SalonOfBeauty/Content/img/Products/Repair.jpg")

            //       },


             context.SaveChanges();

        }
    }
}

