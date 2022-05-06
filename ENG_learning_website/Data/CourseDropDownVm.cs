using ENG_learning_website.Models;
namespace ENG_learning_website.Data
{
    public class CourseDropDownVm
    {
        public CourseDropDownVm()
        {
            Lessons = new List<Lesson>();
        }
        public List<Lesson> Lessons { get; set; }  
    }
}
