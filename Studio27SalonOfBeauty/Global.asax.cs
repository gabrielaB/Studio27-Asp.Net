using AutoMapper;
using Studio27SalonOfBeauty.Models.BindingModels;
using Studio27SalonOfBeauty.Models.EntityModels;
using Studio27SalonOfBeauty.Models.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Studio27SalonOfBeauty
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ConfigureAutoMapper();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private static void ConfigureAutoMapper()
        {

            Mapper.Initialize(expression =>
            {
                expression.CreateMap<Product, AddProductBinding>();
                expression.CreateMap<EditProductBinding, Product>();
                expression.CreateMap<Product, EditProductViewModel>();

            });
        }
    }
}
