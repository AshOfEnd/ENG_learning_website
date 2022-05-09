using ENG_learning_website.Data.services;
using ENG_learning_website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ENG_learning_website.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly IAssignmentService _service;
        public AssignmentController(IAssignmentService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
          //  dynamic dy = new ExpandoObject();
            var dropDownData = await _service.getDropDownValues();
            ViewBag.assignment = new SelectList(dropDownData.Lesson, "Id", "Name");
            var data = await _service.GetAll();
            return View(data);
        }



        public async Task<IActionResult> Details(int id)
        {

            var assignmentDetails = await _service.GetByIdAsync(id);

            if (assignmentDetails == null) return View();
            return View(assignmentDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var dropDownData = await _service.getDropDownValues();
            ViewBag.Courses = new SelectList(dropDownData.Lesson, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Assignment assignment)
        {

            _service.Add(assignment);

            return RedirectToAction(nameof(Index));
        }

     

        
    }
}
