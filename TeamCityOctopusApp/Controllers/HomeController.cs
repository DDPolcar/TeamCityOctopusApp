using System.Web.Mvc;
using Hydra.Framework.Base;


namespace TeamCityOctopusApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new HydraContext().CallInfo.CallId;

            return View(context);
          //  return View();
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