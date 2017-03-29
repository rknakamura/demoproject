using System.Web.Mvc;
using DemoProject.Business.Interface;
using DemoProject.Extension;

namespace DemoProject.Controllers
{
    public class HomeController : Controller
    {
        private IHome _home;

        public HomeController(IHome home)
        {
            _home = home;
        }

        public ActionResult Index()
        {
            var model = _home.GetHome().toView();
            return View(model);
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