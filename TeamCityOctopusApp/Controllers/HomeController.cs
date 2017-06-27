using System.Web.Mvc;



namespace TeamCityOctopusApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                       return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Zmiana23";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}