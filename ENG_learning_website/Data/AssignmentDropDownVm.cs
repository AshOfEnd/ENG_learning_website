using ENG_learning_website.Models;

namespace ENG_learning_website.Data
{
    public class AssignmentDropDownVm
    {

        public AssignmentDropDownVm()
        {
            Lesson = new List<Lesson>();
        }
        public List<Lesson> Lesson { get; set; }
    }
}
