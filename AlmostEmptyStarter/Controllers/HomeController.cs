using Microsoft.AspNetCore.Mvc;

namespace AlmostEmptyStarter.Controllers
{
    public class HomeController : Controller
    {
        // Home/Index
        public IActionResult Index()
        {
            /* Sets Title to Viewdata, optional if
             * already present elsewhere in code
            ViewData["Title"] = "Home Page";
            */
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
