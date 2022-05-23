namespace ENG_learning_website.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        public string   Name { get; set; }

        public bool subscription { get; set; }

        public int points { get; set; }
        
        public List<ClientLang> Clientlangs { get; set; }
    }
}
