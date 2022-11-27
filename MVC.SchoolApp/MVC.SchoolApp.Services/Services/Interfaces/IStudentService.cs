using MVC.SchoolApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.SchoolApp.Services.Services.Interfaces
{
    public interface IStudentService
    {
        void AddStudent(Student student);
    }
}
