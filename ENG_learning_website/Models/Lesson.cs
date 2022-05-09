using System.ComponentModel.DataAnnotations.Schema;

namespace ENG_learning_website.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int NoobsHolder { get; set; }

        public int CourseId { get; set; }
        [ForeignKey ("CourseId")]
        public Course Course { get; set; }

        public List<Assignment> Tasks { get; set; }
    }
}
