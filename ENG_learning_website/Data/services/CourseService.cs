using ENG_learning_website.Models;
using Microsoft.EntityFrameworkCore;

namespace ENG_learning_website.Data.services
{
    public class CourseService : ICourseService
    {

        private readonly DBContext _dbContext;

        public CourseService(DBContext context)
        {
            _dbContext = context;
        }
        public void Add(Course course)
        {
          var result= _dbContext.Add(course);
            _dbContext.SaveChanges();
        }

        public void Delete(Course course)
        {
            throw new NotImplementedException();
        }

        public async Task <IEnumerable<Course>> GetAll()
        {
            var result= await _dbContext.Courses.ToListAsync();
            return result;
        }

        public Course GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Course Update(int id, Course course)
        {
            throw new NotImplementedException();
        }
    }
}
