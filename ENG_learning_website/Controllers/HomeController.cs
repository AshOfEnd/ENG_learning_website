using ENG_learning_website.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ENG_learning_website.Controllers
{
    public class HomeController : Controller
    {
  

 

        public IActionResult Index()
        {
            return View();
        }

        [Authorize (Roles ="Admin")]
        public IActionResult Index2()
        {
            return View();
        }

    }
}