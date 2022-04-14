using Graduate_Program.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graduate_Program.DataAccess.Repositories
{
    public class ProjectRepository : IRepository<Project>
    {
        private readonly ProgramContextDb _dbContext;

        public ProjectRepository(ProgramContextDb dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteById(int id)
        {
            Project project = _dbContext.Projects.FirstOrDefault(x => x.Id == id);
            if (project != null)
            {
                _dbContext.Projects.Remove(project);
                _dbContext.SaveChanges();
            }
        }

        public List<Project> GetAll()
        {
            return _dbContext.Projects
                .Include(x => x.EmployeeProjects)
                .ThenInclude(x => x.Employee)
                .ToList();
        }

        public Project GetById(int id)
        {
            return _dbContext.Projects
                .Include(x => x.EmployeeProjects)
                .ThenInclude(x => x.Employee)
                .FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Project entity)
        {
            _dbContext.Projects.Add(entity);
            int id = _dbContext.SaveChanges();
            return id;
        }

    

        public void Update(Project entity)
        {
            Project project = _dbContext.Projects.FirstOrDefault(x => x.Id == entity.Id);
            if (project != null)
            {
                project.Name = entity.Name;
                project.StartDate = entity.StartDate;
                project.EndDate = entity.EndDate;
                project.EmployeeProjects = entity.EmployeeProjects;
                _dbContext.Projects.Update(project);
                _dbContext.SaveChanges();
            }
        }


    }
}
