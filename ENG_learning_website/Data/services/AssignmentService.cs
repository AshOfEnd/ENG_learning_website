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
        public  async Task<Assignment> GetByIdAsync(int id)
        {
            var result = await _dbContext.Assignment.Include(p => p.Answers).ToListAsync();
            return result.FirstOrDefault(x => x.Id == id);

            //var query=_dbContext.Answers.AsQueryable();

            //var result = _dbContext.Assignment.Include().ToListAsync();


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
                Answers = await _dbContext.Answers.OrderBy(x => x.TextAnswer).ToListAsync()
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

        public Task<IQueryable<Assignment>> GetAnsAsig(int id)
        {
            throw new NotImplementedException();
        }

        //public Task<IEnumerable<Assignment>> GetAnsAsig(int id)
        //{
        //    var result = _dbContext.Assignment.Where(department => department.Id == id)
        //         .Select(department => new
        //         {
        //             Id = department.Id,
        //             AssignmentText = department.AssignmentText,

        //             AnswersForAssignment = department.Answer.Where(department => department.Id == id).Select(answer => new
        //             {

        //                 Id = answer.Id,
        //                 TextAnswer = answer.TextAnswer
        //             })
        //             .AsEnumerable()





        //         }) ;
        //    return result;
        //}


    }
}
