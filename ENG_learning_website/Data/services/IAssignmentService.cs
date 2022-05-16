using ENG_learning_website.Models;
using Microsoft.AspNetCore.Mvc;

namespace ENG_learning_website.Data.services
{
    public interface IAssignmentService
    {
        Task<IEnumerable<Assignment>> GetAllAssignemnts();
        Task<IEnumerable<Answers>> GetAllAnswers();
        Task<IEnumerable<Assignment>> GetAll();
       
        Task<Assignment> GetByIdAsync(int id);

        void Add(Assignment assignemt);

        Assignment Update(int id, Assignment assignemt);

        void Delete(Assignment assignemt);

        Task<AnswersDropDownVm> getDropDownValues();
       
        List<Answers> GetAnswers();

        Task<IQueryable<Assignment>> GetAnsAsig(int id);
    }
}
