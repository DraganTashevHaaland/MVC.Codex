using MVC.SchoolApp.DataAccess.Repository;
using MVC.SchoolApp.DomainModels.Models;
using MVC.SchoolApp.Services.Services.Interfaces;
using MVC.SchoolApp.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC.SchoolApp.Services.Services.Classes
{
    public class SubjectServices : ISubjectService
    {

        private IRepository<Subject> _subjectRepository;

        public SubjectServices(IRepository<Subject> subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        public List<Subject> GetSubjects()
        {
            return _subjectRepository.GetAll();
        }


        public int AddSubjectInSubjects(AddSubjectViewModel subjectModel)
        {
            var LastSubjectId = GetSubjects().Last().Id;

            var subject = new Subject()
            {
                Id = LastSubjectId + 1,
                SubjectName = subjectModel.SubjectName,
                Credits = subjectModel.Credits
            };

            var response = _subjectRepository.Insert(subject);
            return response;
        }

    }
}
