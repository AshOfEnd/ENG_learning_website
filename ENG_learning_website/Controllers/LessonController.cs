using ENG_learning_website.Data;
using ENG_learning_website.Data.services;
using ENG_learning_website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ENG_learning_website.Controllers
{
    public class LessonController : Controller
    {
        private readonly ILessonService _service;
        private readonly DBContext _dbcontext;
        public LessonController(ILessonService service, DBContext dbcontext)
        {
            _service = service;
            _dbcontext = dbcontext;
        }
        public async Task<IActionResult> Index()
        {
            var cos = HttpContext.User.Identity.Name;
            ViewBag.Clients = _dbcontext.Client.Where(x => x.Name == cos).FirstOrDefault();
            var dropDownData = await _service.getDropDownValues();
            ViewBag.Courses = new SelectList(dropDownData.Courses, "Id", "Name");
            var data = await _service.GetAll();
            return View(data);
        }


    
        public async Task<IActionResult> Details(int id)
        {
            var cos = HttpContext.User.Identity.Name;
            ViewBag.Clients = _dbcontext.Client.Where(x => x.Name == cos).FirstOrDefault();
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
