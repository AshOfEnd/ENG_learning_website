using System.ComponentModel.DataAnnotations.Schema;

namespace ENG_learning_website.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string AssignmentText { get; set; }

       
        public int LessonId { get; set; }
        [ForeignKey("LessonId")]
        public Lesson lesson { get; set; }

        public List<Answers> answers { get; set; }  
  

    }
}
