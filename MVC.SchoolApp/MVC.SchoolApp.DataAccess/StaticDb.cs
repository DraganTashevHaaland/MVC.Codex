using MVC.SchoolApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.SchoolApp.DataAccess
{
    public static class StaticDb
    {
        
        public static List<Student> Students { get; set; }
        public static List<Subject> Subjects { get; set; }

        static StaticDb()
        {
            Students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    FirstName = "Dragan",
                    LastName = "Tashev",
                    Email = "dragantashev@yahoo.com",
                    Age = 27
                }
            };

            Subjects = new List<Subject>()
            {
                new Subject()
                {
                    Id = 1,
                    SubjectName = "Geography",
                    Credits = 8
                },

                new Subject()
                {
                    Id = 2,
                    SubjectName = "History",
                    Credits = 8
                },

                new Subject()
                {
                    Id = 3,
                    SubjectName = "Math",
                    Credits = 8
                },

                new Subject()
                {
                    Id = 4,
                    SubjectName = "Chemistry",
                    Credits = 8
                },

                new Subject()
                {
                    Id = 5,
                    SubjectName = "Art",
                    Credits = 6
                },

                new Subject()
                {
                    Id = 6,
                    SubjectName = "Sport",
                    Credits = 4
                },

                new Subject()
                {
                    Id = 7,
                    SubjectName = "Music",
                    Credits = 6
                },

                new Subject()
                {
                    Id = 8,
                    SubjectName = "Biology",
                    Credits = 8
                },

            };
        }
    }
}
