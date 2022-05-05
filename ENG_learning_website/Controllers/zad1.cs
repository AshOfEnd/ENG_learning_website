using Microsoft.AspNetCore.Mvc;

namespace ENG_learning_website.Controllers
{
    public class zad1 : Controller
    {
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }
       

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
