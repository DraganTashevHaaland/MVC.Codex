using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.SchoolApp.DomainModels.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

    }
}
