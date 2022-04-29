using System.ComponentModel.DataAnnotations;

namespace ENG_learning_website.Models
{
    public class Dictionary
    {
        [Key]
        public int DictId { get; set; }

        public string meaningPl { get; set; }
        public string meaningOb { get; set; }

        public List<Language> Languages { get; set; }
    }
}
