using ENG_learning_website.Models;

namespace ENG_learning_website.Data.services
{
    public interface IAnswersService
    {

        Task<IEnumerable<Answers>> GetAll();
        Task<Answers> GetByIdAsync(int id);

        void Add(Answers assignemt);

        Answers Update(int id, Answers assignemt);

        void Delete(Answers assignemt);

        Task<AnswersDropDownVm> getDropDownValues();
  
    }
}
