using ENG_learning_website.Models;

namespace ENG_learning_website.ViewModel
{
    public class AnswerAsignmentModel
    {

        public IEnumerable<Answers> Answers { get; set; }
        public IEnumerable<Assignment> Assignments { get; set; }
    }
}
