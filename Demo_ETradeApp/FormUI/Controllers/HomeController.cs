using Microsoft.AspNetCore.Mvc;

namespace FormUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
