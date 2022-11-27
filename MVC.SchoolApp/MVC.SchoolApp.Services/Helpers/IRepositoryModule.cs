using Microsoft.Extensions.DependencyInjection;
using MVC.SchoolApp.DataAccess.Repository;
using MVC.SchoolApp.DataAccess.Repository.Repositories;
using MVC.SchoolApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.SchoolApp.Services.Helpers
{
    public static class IRepositoryModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<Subject>, SubjectRepository>();
            services.AddTransient<IRepository<Student>, StudentRepository>();

            return services;
        }
    }
}
