using ENG_learning_website.Models;

namespace ENG_learning_website.Data
{
    public class AnswersDropDownVm
    {
        public AnswersDropDownVm()
        {
            Answers = new List<Answers>();
        }
        public List<Answers> Answers { get; set; }
    }
}
