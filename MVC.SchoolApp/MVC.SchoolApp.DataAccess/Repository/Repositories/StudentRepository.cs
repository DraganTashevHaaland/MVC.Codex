using MVC.SchoolApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC.SchoolApp.DataAccess.Repository.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
     
        public Student GeById(int id)
        {
            return StaticDb.Students.FirstOrDefault(x => x.Id == id);
        }

        public List<Student> GetAll()
        {
            return StaticDb.Students;
        }

        public int Insert(Student entity)
        {
            StaticDb.Students.Add(entity);
            return entity.Id;
        }   

        public void Update(Student entity)
        {
            var student = StaticDb.Students.FirstOrDefault(x => x.Id == entity.Id);
            if (student != null)
            {
                var index = StaticDb.Students.IndexOf(student);
                StaticDb.Students[index] = entity;
            }
        }

        public void DeleteById(int id)
        {
            var student = StaticDb.Students.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {

                StaticDb.Students.Remove(student);
            }
        }

    }
}
