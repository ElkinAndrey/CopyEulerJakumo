using Microsoft.AspNetCore.Mvc;

namespace EulerJakumo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View((object)"!dlrow olleH");
        }
    }
}
