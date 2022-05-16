using System.ComponentModel.DataAnnotations.Schema;

namespace ENG_learning_website.Models
{
    public class Answers
    {
        public int Id { get; set; } 
        public string TextAnswer { get; set; }

        public bool Real { get; set; }

        public int ZadId { get; set; }
        [ForeignKey("ZadId")]

        public Assignment assignment { get; set; } 
 
    }
}
