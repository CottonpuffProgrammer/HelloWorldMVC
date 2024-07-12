using Microsoft.AspNetCore.Mvc;

namespace AlmostEmptyStarter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
