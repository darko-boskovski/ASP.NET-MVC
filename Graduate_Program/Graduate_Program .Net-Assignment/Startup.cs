using Graduate_Program.DataAccess.Repositories;
using Graduate_Program.Domain.Models;
using Graduate_Program.Services.Services.Implementation;
using Graduate_Program.Services.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graduate_Program_.Net_Assignment
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<ProgramContextDb>(x => x.UseSqlServer("Server=localhost;Database=GraduateProgram;Trusted_Connection=True"));

            services.AddTransient<IClientInterface, ClientService>();
            services.AddTransient<IProjectInterface, ProjectService>();
            services.AddTransient<IEmployeeInterface, EmployeeService>();

            services.AddTransient<IRepository<Client>, ClientRepository>();
            services.AddTransient<IRepository<Project>, ProjectRepository>();
            services.AddTransient<IRepository<Employee>, EmployeeRepository>();




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
