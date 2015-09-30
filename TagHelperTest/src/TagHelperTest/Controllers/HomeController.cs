using Microsoft.AspNet.Mvc;

namespace TagHelperTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}