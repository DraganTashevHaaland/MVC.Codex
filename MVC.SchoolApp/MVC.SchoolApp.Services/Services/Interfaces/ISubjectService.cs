using MVC.SchoolApp.DomainModels.Models;
using MVC.SchoolApp.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.SchoolApp.Services.Services.Interfaces
{
    public interface ISubjectService
    {
        List<Subject> GetSubjects();

        int AddSubjectInSubjects(AddSubjectViewModel subjectModel);
        

    }
}
