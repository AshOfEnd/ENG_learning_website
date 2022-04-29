using ENG_learning_website.Data;
using ENG_learning_website.Data.services;
using ENG_learning_website.Models;
using Microsoft.AspNetCore.Mvc;

namespace ENG_learning_website.Controllers
{
    public class CourseController : Controller
    {

        private readonly ICourseService _service;
        public CourseController(ICourseService service)
        {
            _service= service;
        }

        public async  Task <IActionResult> Index()
        {
          var data=await _service.GetAll(); 
            return View(data);
        }

        //get
        [HttpGet]
        public async Task<IActionResult> Create()
        {

            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Create(Course kurs)
        {
            _service.Add(kurs);
           
            return RedirectToAction(nameof(Index));
        }







    }
}
