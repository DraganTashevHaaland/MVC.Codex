using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVC.SchoolApp.Services.Helpers;
using MVC.SchoolApp.Services.Services.Classes;
using MVC.SchoolApp.Services.Services.Interfaces;

namespace MVC.SchoolApp.WebApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<ISubjectService, SubjectServices>();

           

            IRepositoryModule.RegisterRepositories(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        [Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

      

            app.UseCookiePolicy();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});

            app.UseAuthentication();
            app.UseRouting();
           


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
