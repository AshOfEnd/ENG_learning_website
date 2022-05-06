using ENG_learning_website.Models;

namespace ENG_learning_website.Data.services
{
    public interface ICourseService
    {
       Task <IEnumerable<Course>> GetAll();
      Task  <Course> GetByIdAsync(int id);

        void Add(Course course);    

        Course Update(int id,Course course);

        void Delete(Course course); 

        Task <CourseDropDownVm> getDropDownValues();

     
    }
}
