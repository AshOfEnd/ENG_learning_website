namespace ENG_learning_website.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        
        public int Difficulty { get; set; }
       
        public List<Lesson> Lessons { get; set; }

    }
}
