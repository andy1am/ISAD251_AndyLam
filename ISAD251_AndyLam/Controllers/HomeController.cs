using System.Web.Mvc;

namespace ISAD251_AndyLam.Controllers {
    public class HomeController : Controller {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult About() {
            ViewBag.Message = "About Us";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Contact Us";

            return View();
        }
    }
}
