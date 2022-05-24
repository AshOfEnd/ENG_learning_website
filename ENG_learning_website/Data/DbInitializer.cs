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
                        new Course()
                        {
                           Name ="kurs premium 1",
                           Difficulty =1
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
                            Name="lesson 1",
                            NoobsHolder = 2,
                            CourseId=1,

                        },
                       new Lesson()
                        {
                            Name="lesson 2",
                            NoobsHolder = 2,
                            CourseId=1,

                        },

                         new Lesson()
                        {
                            Name="lesson 3",
                            NoobsHolder = 2,
                            CourseId=1,

                        },
                       new Lesson()
                        {
                            Name="lesson 4",
                            NoobsHolder = 2,
                            CourseId=1,

                        },
                       new Lesson()
                        {
                            Name="lesson 5",
                            NoobsHolder = 2,
                            CourseId=1,

                        },
                       new Lesson()
                        {
                            Name="lesson 1",
                            NoobsHolder = 2,
                            CourseId=2,

                        },
                       new Lesson()
                        {
                            Name="lesson 2",
                            NoobsHolder = 2,
                            CourseId=2,

                        },
                       new Lesson()
                        {
                            Name="lesson 3",
                            NoobsHolder = 2,
                            CourseId=2,

                        },
                       new Lesson()
                        {
                            Name="lesson 4",
                            NoobsHolder = 2,
                            CourseId=2,
                       },
                            new Lesson()
                        {
                            Name="lesson 5",
                            NoobsHolder = 2,
                            CourseId=2,

                        },
                            new Lesson()
                        {
                            Name="lesson 1",
                            NoobsHolder = 2,
                            CourseId=3,

                        },
                            new Lesson()
                        {
                            Name="lesson 2",
                            NoobsHolder = 2,
                            CourseId=3,

                        },
                            new Lesson()
                        {
                            Name="lesson 3",
                            NoobsHolder = 2,
                            CourseId=3,

                        },
                            new Lesson()
                        {
                            Name="lesson 4",
                            NoobsHolder = 2,
                            CourseId=3,

                        },
                            new Lesson()
                        {
                            Name="lesson 5",
                            NoobsHolder = 2,
                            CourseId=3,

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
                          AssignmentText ="Jak po angielsku mowimy czesc?",
                          curiosity="Zazwyczaj witamy się, mówiąc 'hi' lub 'hello'.  'Hi' jest nieco bardziej kolokwialne.",
                          LessonId=1,


                        },
                       new Assignment()
                        {
                          AssignmentText ="Przedstaw się - 'Mam na imie...'",
                          curiosity="Kiedy ktoś pyta 'What's your name?', możesz odpowiedzieć na dwa sposoby: My name is Alex.  (Mam na imię Alex.) I am Alex. (Jestem Alex.)",
                          LessonId=2,


                        },

                          new Assignment()
                        {
                          AssignmentText ="Hi, how are you?",
                          curiosity="How's it going?” ma podobne znaczenie do 'how are you?'. 'How's it going?' zazwyczaj używamy w stosunku do przyjaciół. ",
                          LessonId=3,


                        },
                        new Assignment()
                        {
                          AssignmentText ="Co mówimy na zakończenie rozmowy?",
                          curiosity="'Bye' jest skróconą formą od 'goodbye'. 'Bye' częściej usłyszysz w codziennej rozmowie.",
                          LessonId=4,


                        },
                        new Assignment()
                        {
                          AssignmentText ="Czy 'good' i 'great' mozemy uzywac wymiennie?",
                          curiosity="Najkrótsze zdanie w języku angielskim to 'I am'.",
                          LessonId=5,


                        },
                        new Assignment()
                        {
                          AssignmentText ="Jak mowimy 'pies'?",
                          curiosity="Żadne słowo nie rymuje się ze słowem 'month' (miesiąc), 'orange' (pomarańczowy) i 'purple' (purpurowy)",
                          LessonId=6,


                        },
                        new Assignment()
                        {
                          AssignmentText ="Jak mowimy 'wesele'?",
                          curiosity="Zapraszając kogos na wesele, nie zrobmy literowki bo 'weeding' oznacza wyrywanie chwastow. ",
                          LessonId=7,


                        },
                        new Assignment()
                        {
                          AssignmentText ="Jak mówimy 'dzien dobry'?",
                          curiosity="Najdłuższym angielskim słowem bez prawdziwej samogłoski (a, e, i, o lub u) jest 'rhythm'.",
                          LessonId=8,


                        },
                        new Assignment()
                        {
                          AssignmentText ="Jak mówimy 'Kocham cie'?",
                          curiosity="Co roku do słownika angielskiego dodaje się około 4 tysięcy nowych słów.",
                          LessonId=9,
                        },

                          new Assignment()
                        {
                          AssignmentText ="Jak mówimy 'chleb'?",
                          curiosity="Zdanie, które zawiera wszystkie 26 liter alfabetu nazywa się 'panagramem'. Oto i ono: 'The quick brown fox jumps over the lazy dog'.",
                          LessonId=10,

                        },
                          new Assignment()
                        {
                          AssignmentText ="Uzupelnij: Mr Smith's ... [kind] is almost beyond belief",
                          curiosity="Zdanie 'The sixth sick sheik's sixth sheep's sick' jest uznane za najtrudniejszy łamaniec językowy ",
                          LessonId=11,


                        },
                          new Assignment()
                        {
                          AssignmentText ="Ile mamy czasow w jezyku angielskim?",
                          curiosity="Angielski wyraz 'four' (cztery) jest jedynym zapisem cyfry, który ma tyle samo liter ile wynosi jego wartość.",
                          LessonId=12,


                        },
                          new Assignment()
                        {
                          AssignmentText ="Jak powiedziec 'trucizna'?",
                          curiosity="Słowo 'set' posiada najwięcej różnych definicji",
                          LessonId=13,


                        },
                          new Assignment()
                        {
                          AssignmentText ="Uzupelnij: Several ... [protest] have been arrested during an anti-racism march in central London.",
                          curiosity="Najstarsze angielskie słowo używane do tej pory to 'town' ",
                          LessonId=14,


                        },
                           new Assignment()
                        {
                          AssignmentText ="Najkrotsze najczesciej uzywane slowo to?",
                          curiosity="Ponad 85% danych przechowywanych w komputerach na całym świecie jest w języku angielskim.",
                          LessonId=15,


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
                         TextAnswer="Hi",
                         ZadId=1,



                        },
                       new Answers()
                        {
                            Real=true,
                         TextAnswer="My name is...",
                         ZadId=2,


                        },

                          new Answers()
                        {
                            Real=true,
                         TextAnswer="I am fine, thanks.",
                         ZadId=3,


                        },
                        new Answers()
                        {
                           Real=true,
                         TextAnswer="Bye",
                         ZadId=4,


                        },
                          new Answers()
                        {
                           Real=true,
                         TextAnswer="tak",
                         ZadId=5,


                        },
                            new Answers()
                        {
                           Real=true,
                         TextAnswer="Dog",
                         ZadId=6,


                        },
                              new Answers()
                        {
                           Real=true,
                         TextAnswer="Wedding",
                         ZadId=7,


                        },
                               new Answers()
                        {
                           Real=true,
                         TextAnswer="Good Morning",
                         ZadId=8,


                        },
                                new Answers()
                        {
                           Real=true,
                         TextAnswer="I love you",
                         ZadId=9,


                        },
                                 new Answers()
                        {
                           Real=true,
                         TextAnswer="Bread",
                         ZadId=10,


                        },
                                  new Answers()
                        {
                           Real=true,
                         TextAnswer="kindness",
                         ZadId=11,


                        },
                                   new Answers()
                        {
                           Real=true,
                         TextAnswer="16",
                         ZadId=12,


                        },
                                    new Answers()
                        {
                           Real=true,
                         TextAnswer="poison",
                         ZadId=13,


                        },
                                     new Answers()
                        {
                           Real=true,
                         TextAnswer="protestors",
                         ZadId=14,


                        },
                                      new Answers()
                        {
                           Real=true,
                         TextAnswer="I",
                         ZadId=15,


                        },

                };

                    _DBContext.Answers.AddRange(answers);
                    _DBContext.SaveChanges();
                }

            if (!_DBContext.Dictionary.Any())
            {
                var dictionary = new List<Dictionary>()
                {
                        new Dictionary()
                        {
                           meaningOb="House",
                           meaningPl="Dom"

                        },
                        new Dictionary()
                        {
                           meaningOb="Dog",
                           meaningPl="Pies"

                        },
                        new Dictionary()
                        {
                           meaningOb="Noz",
                           meaningPl="Knife"

                        },
                        new Dictionary()
                        {
                           meaningOb="fork",
                           meaningPl="widelec"

                        },
                        new Dictionary()
                        {
                           meaningOb="cat",
                           meaningPl="kot"

                        },
                        new Dictionary()
                        {
                           meaningOb="table",
                           meaningPl="stol"

                        },
                        new Dictionary()
                        {
                           meaningOb="chair",
                           meaningPl="krzeslo"

                        },
                        new Dictionary()
                        {
                           meaningOb="monster",
                           meaningPl="potwor"

                        },
                        new Dictionary()
                        {
                           meaningOb="window",
                           meaningPl="okno"

                        },
                        new Dictionary()
                        {
                           meaningOb="ball",
                           meaningPl="pilka"

                        },
                        new Dictionary()
                        {
                           meaningOb="notebook",
                           meaningPl="zeszyt"

                        },
                        new Dictionary()
                        {
                           meaningOb="pen",
                           meaningPl="dlugopis"

                        },
                        new Dictionary()
                        {
                           meaningOb="pencil",
                           meaningPl="olowek"

                        },
                         new Dictionary()
                        {
                           meaningOb="ladybug",
                           meaningPl="biedronka"

                        },
                          new Dictionary()
                        {
                           meaningOb="cup",
                           meaningPl="filizanka"

                        },
                           new Dictionary()
                        {
                           meaningOb="flower",
                           meaningPl="kwiatek"

                        },
                            new Dictionary()
                        {
                           meaningOb="trousers",
                           meaningPl="spodnie"

                        },


                };

                _DBContext.Dictionary.AddRange(dictionary);
                _DBContext.SaveChanges();
            }




        }
    }
}
