using Graduate_Program.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.DataAccess.Repositories
{
    public class ProgramContextDb : DbContext    {
        public ProgramContextDb(DbContextOptions options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Employee>()
                .HasMany(x => x.EmployeeProjects)
                .WithOne(x => x.Employee)
                .HasForeignKey(x => x.EmployeeId);

            modelBuilder.Entity<Project>()
                .Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Project>()
                .Property(x => x.StartDate)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Project>()
                .HasMany(x => x.EmployeeProjects)
                .WithOne(x => x.Project)
                .HasForeignKey(x => x.ProjectId);

            modelBuilder.Entity<Client>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Client>()
                .HasData(
                new Client()
                {
                    Id = 1,
                    FullName = "Polar Cape Macedonia",
                    MobilePhone = 076361019,
                    EmailAddress = "jobs_mk@polarcape.com",
                    Company = "PolarCape"
                 
                },
                 new Client()
                 {
                     Id = 2,
                     FullName = "Fake Company Macedonia",
                     MobilePhone = 070000000,
                     EmailAddress = "company_mk@fake.com",
                     Company = "CompanyTwo"

                 }
                ) ;

            modelBuilder.Entity<Employee>()
            .HasData(
            new Employee()
            {
                Id = 1,
                FullName = "Darko Boshkovski",
                MobilePhone = 075456697,
                EmailAddress = "darkoboskovski.01@gmail.com",
                EmployeeNumber = 1,

            },
              new Employee()
              {
                  Id = 2,
                  FullName = "John Doe",
                  MobilePhone = 077777777,
                  EmailAddress = "johndoe@gmail.com",
                  EmployeeNumber = 2,

              },
              new Employee()
              {
                  Id = 3,
                  FullName = "Jane Doe",
                  MobilePhone = 073333333,
                  EmailAddress = "janedoe@gmail.com",
                  EmployeeNumber = 3,

              }
            ) ;




        }
    }
}
