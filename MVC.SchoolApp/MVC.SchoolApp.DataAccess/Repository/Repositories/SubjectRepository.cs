using MVC.SchoolApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC.SchoolApp.DataAccess.Repository.Repositories
{
    public class SubjectRepository : IRepository<Subject>
    {
       
        public Subject GeById(int id)
        {
            return StaticDb.Subjects.FirstOrDefault(x => x.Id == id);
        }

        public List<Subject> GetAll()
        {
            return StaticDb.Subjects;
        }

        public int Insert(Subject entity)
        {
            StaticDb.Subjects.Add(entity);
            return entity.Id;
        }

        public void Update(Subject entity)
        {
            var subject = StaticDb.Subjects.FirstOrDefault(x => x.Id == entity.Id);
            if (subject != null)
            {
                var index = StaticDb.Subjects.IndexOf(subject);
                StaticDb.Subjects[index] = entity;
            }
        }

        public void DeleteById(int id)
        {
            var subject = StaticDb.Subjects.FirstOrDefault(x => x.Id == id);
            if (subject != null)
            {
                StaticDb.Subjects.Remove(subject);
            }
        }
    }
}
