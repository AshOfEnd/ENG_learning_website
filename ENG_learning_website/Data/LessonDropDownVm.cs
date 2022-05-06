using ENG_learning_website.Models;

namespace ENG_learning_website.Data
{
    public class LessonDropDownVm
    {

        public LessonDropDownVm()
        {
            Courses = new List<Course>();
        }
        public List<Course> Courses { get; set; }
    }
}
