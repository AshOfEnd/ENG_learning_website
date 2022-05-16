using ENG_learning_website.Data;
using ENG_learning_website.Data.services;
using ENG_learning_website.Models;
using ENG_learning_website.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ENG_learning_website.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly IAssignmentService _service;
        private readonly DBContext _dbContext;
        public AssignmentController(IAssignmentService service, DBContext dbContext)
        {
            _service = service;
            _dbContext = dbContext;

        }
        //public  Task<IActionResult> Index()
        //{
        //    ////  dynamic dy = new ExpandoObject();
        //    //  var dropDownData = await _service.getDropDownValues();
        //    //  ViewBag.assignment = new SelectList(dropDownData.Answers, "Id", "AnswerText");
        //    //  var data = await _service.GetAll();
        //    //  return View(data);



        //    return View();
        //}
        //public async Task<IActionResult> Index(int id)
        //{
        //    var courseDropDownData = await _service.getDropDownValues();
        //    ViewBag.Lessons = new SelectList(courseDropDownData.Answers, "Id", "Name");
        //    var CourseDetails = await _service.GetByIdAsync(id);
        //    return View(CourseDetails);
        //}

        public  IActionResult Index(int id)
        {

              var result= _dbContext.Assignment.Include(x=>x.Answers).Where(a=>a.LessonId==id ).OrderBy(x=>x.AssignmentText).ToList();
            //var viewModel = new AnswerAsignmentModel();
            // viewModel.Assignments = _dbContext.Assignment.Include(i=>i.Answer).Where(a=>a.LessonId==id).OrderBy(i=>i.AssignmentText).ToList();

         //  var resultt=_dbContext.Answers.Include(x=>x.assignment).Where(a=>a.assignment.LessonId==id).OrderBy(x=>x.assignment.AssignmentText).ToList();

            return View(result);
        }


        public async Task<IActionResult> Details(int id)
        {
            //var courseDropDownData = await _service.getDropDownValues();
            //ViewBag.Lessons = new SelectList(courseDropDownData.Answers, "Id", "Name");
            //var CourseDetails = await _service.GetByIdAsync(id);
            //return View(CourseDetails);
            //var assignmentDetails = await _service.GetByIdAsync(id);

            //if (assignmentDetails == null) return View();
            //return View(assignmentDetails);

            return View();
        }

     

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var dropDownData = await _service.getDropDownValues();
            ViewBag.Courses = new SelectList(dropDownData.Answers, "Id", "AnswerText");
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
