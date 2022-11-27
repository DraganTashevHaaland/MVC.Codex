using MVC.SchoolApp.DataAccess.Repository;
using MVC.SchoolApp.DomainModels.Models;
using MVC.SchoolApp.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC.SchoolApp.Services.Services.Classes
{
    public class StudentService : IStudentService
    {
        private IRepository<Student> _studentRepository;

        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void AddStudent(Student student)
        {
                student.Id = _studentRepository.GetAll().Last().Id + 1;
                _studentRepository.Insert(student);
        }
    }
}
