using ENG_learning_website.Models;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;


namespace ENG_learning_website.Data.services
{
    public class AssignmentService : IAssignmentService
    {

        private readonly DBContext _dbContext;

        public AssignmentService(DBContext context)
        {
            _dbContext = context;
        }
        public void Add(Assignment assignment)
        {
            var result = _dbContext.Add(assignment);
            _dbContext.SaveChanges();
        }

        public void Delete(Assignment assignment)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Assignment>> GetAll()
        {
            var result = await _dbContext.Assignment.ToListAsync();
            return result;
        }
        public async Task<Assignment> GetByIdAsync(int id)
        {
            var result = await _dbContext.Assignment.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public Lesson Update(int id, Assignment assignment)
        {
            throw new NotImplementedException();
        }


        public async Task<AssignmentDropDownVm> getDropDownValues()
        {
            var response = new AssignmentDropDownVm()
            {
                Lesson = await _dbContext.Lessons.OrderBy(x => x.Name).ToListAsync()
            };
            return response;
        }

        Assignment IAssignmentService.Update(int id, Assignment assignemt)
        {
            throw new NotImplementedException();
        }

       public List <Answers> GetAnswers()
        {
             var answers=_dbContext.Answers.ToList();
            return answers;
        }


    }
}
