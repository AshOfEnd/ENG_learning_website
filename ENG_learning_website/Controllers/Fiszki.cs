using Microsoft.AspNetCore.Mvc;

namespace ENG_learning_website.Controllers
{
    public class Fiszki : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
