using Graduate_Program.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graduate_Program.DataAccess.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private readonly ProgramContextDb _dbContext;

        public EmployeeRepository(ProgramContextDb dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteById(int id)
        {
            Employee employee = _dbContext.Employees.FirstOrDefault(x => x.Id == id);
            if (employee != null)
            {
                _dbContext.Employees.Remove(employee);
                _dbContext.SaveChanges();
            }
        }

        public List<Employee> GetAll()
        {
            return _dbContext.Employees
                .Include(x => x.EmployeeProjects)
                .ThenInclude(x => x.Project)
                .ToList();
        }

        public Employee GetById(int id)
        {
            return _dbContext.Employees
                 .Include(x => x.EmployeeProjects)
                 .ThenInclude(x => x.Project)
                 .FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Employee entity)
        {
            _dbContext.Employees.Add(entity);
            int id = _dbContext.SaveChanges();
            return id;
        }

        public void Update(Employee entity)
        {
            Employee employee = _dbContext.Employees.FirstOrDefault(x => x.Id == entity.Id);
            if (employee != null)
            {
                employee.FullName = entity.FullName;
                employee.EmailAddress = entity.EmailAddress;
                employee.MobilePhone = entity.MobilePhone;
                employee.EmployeeNumber = entity.EmployeeNumber;
                employee.EmployeeProjects = entity.EmployeeProjects;
                _dbContext.Employees.Update(employee);
                _dbContext.SaveChanges();
            }
        }
    }
}
