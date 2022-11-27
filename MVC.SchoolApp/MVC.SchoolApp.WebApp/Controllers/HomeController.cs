using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.SchoolApp.Services.Services.Interfaces;
using MVC.SchoolApp.ViewModels.Models;

namespace MVC.SchoolApp.WebApp.Controllers
{
    public class HomeController : Controller
    {

        private ISubjectService _subjectService;
        //[Obsolete]
        private readonly IHostingEnvironment _webhost;

        //[Obsolete]
        public HomeController(ISubjectService subjectService,
                              IHostingEnvironment webhost)
        {
            _subjectService = subjectService;
            _webhost = webhost;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Index(HomeViewModel homeModel)
        {
            return RedirectToAction("Add", new { subjects = homeModel.Id });
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Subject()
        {
            var dbSubjects = _subjectService.GetSubjects();

            var subjects = new List<SubjectViewModel>();

            foreach (var subject in dbSubjects)
            {
                var tempSubject = new SubjectViewModel()
                {
                    SubjectName = subject.SubjectName,
                    Credits = subject.Credits,

                };

                subjects.Add(tempSubject);
            }

            var subjectViewModel = new SubjectsViewModel()
            {
                Subjects = subjects,
            };

            return View(subjectViewModel);

        }

        public IActionResult AddSubject(AddSubjectViewModel model)
        {
            _subjectService.AddSubjectInSubjects(model);
            return RedirectToAction("Subjects");
        }


        public IActionResult Privacy()
        {
            return View();
        }
    }
}
