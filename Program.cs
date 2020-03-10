using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main (string[] args)
        {
            var cohort36 = new Cohort ()
            {
                Name = "C36"
            };
            var cohort37 = new Cohort ()
            {
                Name = "C37"
            };
            var cohort39 = new Cohort ()
            {
                Name = "C39"
            };
            var instructors = new List<Instructor> ();
            instructors.Add (new Instructor
            {
                Cohort = cohort39,
                    Name = "Steve",
                    Specialty = "Bad jokes",
            });
            instructors.Add (new Instructor
            {
                Cohort = cohort37,
                    Name = "Leah",
                    Specialty = "awesomeness",
            });
            instructors.Add (new Instructor
            {
                Cohort = cohort39,
                    Name = "Mo",
                    Specialty = "being smart",
            });
            instructors.Add (new Instructor
            {
                Cohort = cohort37,
                    Name = "Adam",
                    Specialty = "too early to tell",
            });
            var students = new List<Student> ();
            students.Add (new Student
            {
                Cohort = cohort36,
                    FirstName = "Sam",
                    LastName = "Pita",
                    Exercises = new List<Exercise> ()
                    {
                        new Exercise ()
                            {
                                Name = "Student Exercise",
                                    Language = "C#"
                            },
                            new Exercise ()
                            {
                                Name = "Kennels",
                                    Language = "JS"
                            }
                    }

            });
            students.Add (new Student
            {
                Cohort = cohort37,
                    FirstName = "Case",
                    LastName = "Scally",
                    Exercises = new List<Exercise> ()
                    {
                        new Exercise ()
                        {
                            Name = "Glassdale",
                                Language = "JS"
                        }
                    }
            });
            students.Add (new Student
            {
                Cohort = cohort37,
                    FirstName = "Onterio",
                    LastName = "Wright",
                    Exercises = new List<Exercise> ()
                    {
                        new Exercise ()
                        {
                            Name = "Student Exercise",
                                Language = "C#"
                        }
                    }
            });
            students.Add (new Student
            {
                Cohort = cohort37,
                    FirstName = "Luis",
                    LastName = "Chavez"
            });
            students.Add (new Student
            {
                Cohort = cohort37,
                    FirstName = "Tyler",
                    LastName = "Davis",
                    Exercises = new List<Exercise> ()
                    {
                        new Exercise ()
                        {
                            Name = "Martin's Aquarium",
                                Language = "HTML"
                        }
                    }
            });

            var exercises = new List<Exercise>
            {
                new Exercise
                {
                Language = "C#",
                Name = "Student Exercise"
                },
                new Exercise
                {
                Language = "JS",
                Name = "Kennels"
                },
                new Exercise
                {
                Language = "JS",
                Name = "Glassdale"
                },
                new Exercise
                {
                Language = "React",
                Name = "Nutshell"
                },
                new Exercise
                {
                Language = "HTML",
                Name = "Martin's Aquarium"
                },
            };

            var InstructorCohort = instructors.Where (instructor =>
            {
                return instructor.Cohort == cohort37;
            });
            Console.WriteLine ("Cohort 37 instructors:");

            foreach (var instructor in InstructorCohort)
            {
                Console.WriteLine ($"{instructor.Name}");
            }
            Console.WriteLine ($"---------------------------------------");

            var allJsExercise = exercises.Where (exercise =>
            {
                return exercise.Language == "JS";
            });

            foreach (var exercise in allJsExercise)
            {
                Console.WriteLine ($"Javascript Exercise: {exercise.Name}");
            }

            var studentsOrderedByLastName = students.OrderByDescending (student =>
            {
                return student.LastName;
            });
            Console.WriteLine ($"---------------------------------------");
            Console.WriteLine ("Students:");

            foreach (var student in studentsOrderedByLastName)
            {
                Console.WriteLine ($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine ($"---------------------------------------");

            var studentsWithNoExercises = students.Where (student =>
            {
                int exercisesCount = student.Exercises.Count;
                return exercisesCount == 0;
            });

            Console.WriteLine ("These students are not working on an exercise:");

            foreach (var student in studentsWithNoExercises)
            {
                Console.WriteLine ($"{student.FirstName} {student.LastName}");
            }

            Console.WriteLine ($"---------------------------------------");

            var studentWithMostExercises = students.OrderByDescending (student =>
            {
                return student.Exercises.Count;
            }).FirstOrDefault ();

            var groups = students.GroupBy (student => student.Cohort.Name);

            foreach (var group in groups)
            {
                Console.WriteLine ($"There are {group.Count()} student(s) in {group.Key}");
            }
        }
    }
}