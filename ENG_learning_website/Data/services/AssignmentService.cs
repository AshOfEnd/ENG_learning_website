using ENG_learning_website.Models;
using Microsoft.AspNetCore.Mvc;
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
            var result = await _dbContext.Assignment.Include("Answer").ToListAsync();
            return result;
        }
        public async Task<Assignment> GetByIdAsync(int id)
        {
            var result = await _dbContext.Assignment.Include("Answer").ToListAsync();
            return result.FirstOrDefault(x => x.Id == id);
        }

        public Lesson Update(int id, Assignment assignment)
        {
            throw new NotImplementedException();
        }




  

       public List <Answers> GetAnswers()
        {
             var answers=_dbContext.Answers.ToList();
            return answers;
        }

        Assignment IAssignmentService.Update(int id, Assignment assignemt)
        {
            throw new NotImplementedException();
        }

        public async Task<AnswersDropDownVm> getAnswersDropDownValues()
        {
            var response = new AnswersDropDownVm()
            {
                Answers = await _dbContext.Answers.OrderBy(x => x.Id).ToListAsync()
            };
          return response;
        }

 

       public async Task<AnswersDropDownVm> getDropDownValues()
        {
            var response = new AnswersDropDownVm()
            {
                Answers = await _dbContext.Answers.OrderBy(x => x.Id).ToListAsync()
            };
            return response;
        }

        public async Task<IEnumerable<Assignment>> GetAllAssignemnts()
        {
            var result = await _dbContext.Assignment.ToListAsync();
            return result;
        }

        public async Task<IEnumerable<Answers>> GetAllAnswers()
        {
            var result = await _dbContext.Answers.ToListAsync();
            return result;
        }

     
    }
}
