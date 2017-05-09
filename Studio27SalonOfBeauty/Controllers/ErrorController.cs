using System.Web.Mvc;

namespace Studio27SalonOfBeauty.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult InvalidSendMailModel()
        {
            return View();
        }
    }
}