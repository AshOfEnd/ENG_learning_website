using ENG_learning_website.Models;
using Microsoft.EntityFrameworkCore;

namespace ENG_learning_website.Data.services
{
    public class AnswersService : IAnswersService
    {
        private readonly DBContext _dbContext;

        public AnswersService(DBContext context)
        {
            _dbContext = context;
        }
        public void Add(Answers assignemt)
        {
            throw new NotImplementedException();
        }

        public void Delete(Answers assignemt)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Answers>> GetAll()
        {
            var result = await _dbContext.Answers.ToListAsync();
            return result;
        }

        public Task<Answers> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<AnswersDropDownVm> getDropDownValues()
        {
            var response = new AnswersDropDownVm();
           
            return response;
        }

        public Answers Update(int id, Answers assignemt)
        {
            throw new NotImplementedException();
        }
    }
}
