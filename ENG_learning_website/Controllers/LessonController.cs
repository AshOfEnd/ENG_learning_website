using ENG_learning_website.Data.services;
using ENG_learning_website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ENG_learning_website.Controllers
{
    public class LessonController : Controller
    {
        private readonly ILessonService _service;
        public LessonController(ILessonService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var dropDownData = await _service.getDropDownValues();
            ViewBag.Courses = new SelectList(dropDownData.Courses, "Id", "Name");
            var data = await _service.GetAll();
            return View(data);
        }


    
        public async Task<IActionResult> Details(int id)
        {
            
            var lessonDetails = await _service.GetByIdAsync(id);

            if (lessonDetails == null) return View();
            return View(lessonDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var dropDownData= await _service.getDropDownValues();
            ViewBag.Courses = new SelectList(dropDownData.Courses,"Id","Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Lesson lesson)
        {
           
            _service.Add(lesson);

            return RedirectToAction(nameof(Index));
        }


    }
}
