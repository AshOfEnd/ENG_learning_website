using System.ComponentModel.DataAnnotations.Schema;

namespace ENG_learning_website.Models
{
    public class Answers
    {
        public int Id { get; set; }
        public string Answer { get; set; }

        public int TaskId { get; set; }
        [ForeignKey("AssigmentId")]

        public Assignment Task { get; set; }

    }
}
