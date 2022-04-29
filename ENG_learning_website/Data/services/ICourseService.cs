﻿using ENG_learning_website.Models;

namespace ENG_learning_website.Data.services
{
    public interface ICourseService
    {
       Task <IEnumerable<Course>> GetAll();
        Course GetById(int id);

        void Add(Course course);    

        Course Update(int id,Course course);

        void Delete(Course course); 
    }
}
