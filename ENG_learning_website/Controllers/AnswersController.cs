using ENG_learning_website.Data.services;
using Microsoft.AspNetCore.Mvc;

namespace ENG_learning_website.Controllers
{
    public class AnswersController : Controller
    {
        private readonly IAnswersService _service;
        public AnswersController(IAnswersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
          return View();
        }

        public async Task<IActionResult> GetAll()
        {
            var answer = await _service.GetAll();
            return View(answer);
        }


       

        //[HttpGet]
        //public async Task<IActionResult> Create()
        //{
        //    var dropDownData = await _service.getDropDownValues();
        //    ViewBag.Courses = new SelectList(dropDownData.Courses, "Id", "Name");
        //    return View();
        //}


        //[HttpPost]
        //public async Task<IActionResult> Create(Lesson lesson)
        //{

        //    _service.Add(lesson);

        //    return RedirectToAction(nameof(Index));
        //}
    }
}
