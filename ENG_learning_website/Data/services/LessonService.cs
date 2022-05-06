using ENG_learning_website.Models;
using Microsoft.EntityFrameworkCore;

namespace ENG_learning_website.Data.services
{
    public class LessonService : ILessonService
    {

        private readonly DBContext _dbContext;

        public LessonService(DBContext context)
        {
            _dbContext = context;
        }
        public void Add(Lesson lesson)
        {
            var result = _dbContext.Add(lesson);
            _dbContext.SaveChanges();
        }

        public void Delete(Lesson lesson)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Lesson>> GetAll()
        {
            var result = await _dbContext.Lessons.ToListAsync();
            return result;
        }
        public async Task<Lesson> GetByIdAsync(int id)
        {
            var result = await _dbContext.Lessons.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public Lesson Update(int id, Lesson lesson)
        {
            throw new NotImplementedException();
        }


        public async Task<LessonDropDownVm> getDropDownValues()
        {
            var response = new LessonDropDownVm()
            {
                Courses = await _dbContext.Courses.OrderBy(x => x.Name).ToListAsync()
            };
            return response;
        }
    }
}
