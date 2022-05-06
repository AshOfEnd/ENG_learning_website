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

        public async Task <Course> GetByIdAsync(int id)
        {
            var result=await _dbContext.Courses.FirstOrDefaultAsync(x=>x.Id==id);
            return result;
        }

        public async Task<CourseDropDownVm> getDropDownValues()
        {
            var response = new CourseDropDownVm()
            {
                Lessons = await _dbContext.Lessons.OrderBy(x => x.Name).ToListAsync()
            };
         return response;
        }

        public Course Update(int id, Course course)
        {
            throw new NotImplementedException();
        }
    }
}
