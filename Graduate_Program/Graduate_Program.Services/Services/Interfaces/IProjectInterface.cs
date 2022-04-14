using Graduate_Program.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.Services.Services.Interfaces
{
    public interface IProjectInterface
    {
        Project GetProjectById(int id);
        List<Project> GetAllProjects();
        public void AddNewProject(Project project);
        public void UpdateExistingProject(Project project);
        public void DeleteProject(int id);
    }
}
