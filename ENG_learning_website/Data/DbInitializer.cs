using ENG_learning_website.Models;

namespace ENG_learning_website.Data
{
    public class DbInitializer : IDbInitializer
    {



        private readonly DBContext _DBContext;

        public DbInitializer(DBContext _context)
        {
            _DBContext = _context;
        }

        public void Seed()
        {
            if (!_DBContext.Courses.Any())
            {
                var course = new List<Course>()
                {
                        new Course()
                        {
                           Name ="kurs1",
                           Difficulty =1
                        },
                        new Course()
                        {
                           Name ="kurs2",
                           Difficulty =2
                        },

                };

                _DBContext.Courses.AddRange(course);
                _DBContext.SaveChanges();
            }


            if (!_DBContext.Lessons.Any())
            {
                var lessons = new List<Lesson>()
                {
                        new Lesson()
                        {
                            Name="lesson 1.1",
                            NoobsHolder = 2,
                            CourseId=1,

                        },
                       new Lesson()
                        {
                            Name="lesson 1.2",
                            NoobsHolder = 2,
                            CourseId=1,

                        },

                         new Lesson()
                        {
                            Name="lesson 2.1",
                            NoobsHolder = 2,
                            CourseId=2,

                        },
                       new Lesson()
                        {
                            Name="lesson 2.2",
                            NoobsHolder = 2,
                            CourseId=2,

                        },

                };
                _DBContext.Lessons.AddRange(lessons);
                _DBContext.SaveChanges();
            }

                if (!_DBContext.Assignment.Any())
                {
                    var assignments = new List<Assignment>()
                {
                        new Assignment()
                        {
                          AssignmentText ="zad1",
                          curiosity="ciekawostka1",
                          LessonId=1,


                        },
                       new Assignment()
                        {
                          AssignmentText ="zad2",
                          curiosity="ciekawostka2",
                          LessonId=2,


                        },

                          new Assignment()
                        {
                          AssignmentText ="zad3",
                          curiosity="ciekawostka3",
                          LessonId=3,


                        },
                        new Assignment()
                        {
                          AssignmentText ="zad4",
                          curiosity="ciekawostka4",
                          LessonId=1,


                        },

                };

                    _DBContext.Assignment.AddRange(assignments);
                    _DBContext.SaveChanges();
                }
                if (!_DBContext.Answers.Any())
                {
                    var answers = new List<Answers>()
                {
                        new Answers()
                        {
                         Real=true,
                         TextAnswer="odp1",
                         ZadId=1,



                        },
                       new Answers()
                        {
                            Real=true,
                         TextAnswer="odp2",
                         ZadId=1,


                        },

                          new Answers()
                        {
                            Real=true,
                         TextAnswer="odp3",
                         ZadId=2,


                        },
                        new Answers()
                        {
                           Real=true,
                         TextAnswer="odp4",
                         ZadId=3,


                        },
                          new Answers()
                        {
                           Real=true,
                         TextAnswer="odp5",
                         ZadId=4,


                        },
                            new Answers()
                        {
                           Real=true,
                         TextAnswer="odp6",
                         ZadId=1,


                        },
                              new Answers()
                        {
                           Real=true,
                         TextAnswer="odp7",
                         ZadId=2,


                        },
                };

                    _DBContext.Answers.AddRange(answers);
                    _DBContext.SaveChanges();
                }

           



        }
    }
}
