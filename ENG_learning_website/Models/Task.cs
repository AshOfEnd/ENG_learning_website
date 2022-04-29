using System.ComponentModel.DataAnnotations.Schema;

namespace ENG_learning_website.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string text { get; set; }

        public int NoobsHolder { get; set; }

        public int LessonId { get; set; }
        [ForeignKey("LessonId")]
        public Lesson lesson { get; set; }

        public List<Answers> Answers { get; set; }
    }
}
