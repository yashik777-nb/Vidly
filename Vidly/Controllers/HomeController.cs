using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    //[RoutePrefix("Home")]
    //[Route] -> Default Cotroller
    [AllowAnonymous] // -> Allow Home Controller to be anonymously loggeed in
    public class HomeController : Controller
    {
       // [Route] // -> Default Action
       // ["~/"] // -> Default Action
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}