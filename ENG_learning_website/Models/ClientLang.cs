using System.ComponentModel.DataAnnotations.Schema;

namespace ENG_learning_website.Models
{
    public class ClientLang
    {
        public int LangId { get; set; }
        [ForeignKey("LangId")]
        public Language Language { get; set; } 

        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
    }
}
