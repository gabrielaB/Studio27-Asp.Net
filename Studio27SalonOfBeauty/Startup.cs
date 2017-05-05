using Microsoft.Owin;
using Owin;
using Studio27SalonOfBeauty.Data;

[assembly: OwinStartupAttribute(typeof(Studio27SalonOfBeauty.Startup))]
namespace Studio27SalonOfBeauty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
       

        }
        
     
    }
}
