using ENG_learning_website.Models;

namespace ENG_learning_website.Data.services
{
    public interface IAssignmentService
    {
        Task<IEnumerable<Assignment>> GetAll();
        Task<Assignment> GetByIdAsync(int id);

        void Add(Assignment assignemt);

        Assignment Update(int id, Assignment assignemt);

        void Delete(Assignment assignemt);

        Task<AssignmentDropDownVm> getDropDownValues();
        List<Answers> GetAnswers();
    }
}
