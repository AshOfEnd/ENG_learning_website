using System.ComponentModel.DataAnnotations.Schema;

namespace ENG_learning_website.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }



        public int DicId { get; set; }
        [ForeignKey ("DicId")]

        public Dictionary dictionary { get; set; }

      public List<ClientLang> ClientLangs { get; set; }

        public List<Course> Courses { get; set; }   
    }
}
