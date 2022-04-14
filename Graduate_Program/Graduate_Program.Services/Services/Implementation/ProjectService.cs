using Graduate_Program.DataAccess.Repositories;
using Graduate_Program.Domain.Models;
using Graduate_Program.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.Services.Services.Implementation
{
    public class ProjectService : IProjectInterface
    {
        private readonly IRepository<Project> _projectRepository;

        public ProjectService(IRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void AddNewProject(Project project)
        {
            if (project.StartDate == null)
                throw new ArgumentNullException("StartDate must be provided");
            if (project.Name == "" || project.Name == null)
                throw new AccessViolationException("Project must contain Title/Name");
            _projectRepository.Insert(project);
        }

        public void DeleteProject(int id)
        {
            _projectRepository.DeleteById(id);
        }

        public List<Project> GetAllProjects()
        {
            return _projectRepository.GetAll();
        }

        public Project GetProjectById(int id)
        {
            return _projectRepository.GetById(id);
        }

        public void UpdateExistingProject(Project project)
        {
            if (project.EmployeeProjects == null || project.EmployeeProjects.Count < 1)
                throw new ArgumentNullException("Employee value cannot be null");
           _projectRepository.Update(project);
        }

    }
}
