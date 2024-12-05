using Microsoft.AspNetCore.Mvc;

namespace EShoppingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

