using ENG_learning_website.Data;
using ENG_learning_website.Data.services;
using ENG_learning_website.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ENG_learning_website.Controllers
{
    public class CourseController : Controller
    {

        private readonly ICourseService _service;
        private readonly DBContext _dbcontext;
        public CourseController(ICourseService service, DBContext dbcontext)
        {
            _service= service;
            _dbcontext= dbcontext;
        }

        [Authorize(Roles ="Admin")]
        public async  Task <IActionResult> Index()
        {
            var cos =   HttpContext.User.Identity.Name;
            ViewBag.Clients = _dbcontext.Client.Where(x => x.Name == cos).FirstOrDefault();
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




        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var cos = HttpContext.User.Identity.Name;
            ViewBag.Clients = _dbcontext.Client.Where(x => x.Name == cos).FirstOrDefault();
            var courseDropDownData=await _service.getDropDownValues();
            ViewBag.Lessons = new SelectList(courseDropDownData.Lessons,"Id","Name");
            var CourseDetails = await _service.GetByIdAsync(id);
            return View(CourseDetails);
        }


    }
}
