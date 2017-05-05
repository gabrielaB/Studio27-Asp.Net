using Studio27SalonOfBeauty.Areas.Admin;
using Studio27SalonOfBeauty.Models.EntityModels;
using Studio27SalonOfBeauty.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Studio27SalonOfBeauty.Areas.Admin.Controllers
{
    
    
    [RouteArea("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private AdminService service;
        public AdminController()
        {
            this.service = new AdminService();
        }

        [HttpGet]
        [Route("Schedule")]
        
        public ActionResult Schedule()
        {
            return View();
        }


        [HttpGet]
        [Route("Administration")]
        public ActionResult Administration()
        {
            return View();
        }

      
        [Route("Customers")]
        public ActionResult Customers()
        {
          IEnumerable<Customer> customersVm = this.service.GetCustomers();
            return View(customersVm);
        }

    }
}