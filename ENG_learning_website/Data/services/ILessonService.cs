using ENG_learning_website.Models;

namespace ENG_learning_website.Data.services
{
    public interface ILessonService
    {
        Task<IEnumerable<Lesson>> GetAll();
        Task<Lesson> GetByIdAsync(int id);

        void Add(Lesson lesson);

        Lesson Update(int id, Lesson lesson);

        void Delete(Lesson lesson);

        Task<LessonDropDownVm> getDropDownValues();



    }
}
