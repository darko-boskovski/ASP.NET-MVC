using Graduate_Program.DataAccess.Repositories;
using Graduate_Program.Domain.Models;
using Graduate_Program.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.Services.Services.Implementation
{
    public class EmployeeService : IEmployeeInterface
    {
        private readonly IRepository<Employee> _employeeRepository;

        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void AddNewEmployee(Employee employee)
        {
            if (employee.EmployeeProjects == null || employee.EmployeeProjects.Count < 1)
                throw new ArgumentNullException("Project value cannot be null");
            _employeeRepository.Insert(employee);
        }

        public void DeleteEmployee(int id)
        {
            _employeeRepository.DeleteById(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetById(id);
        }

        public void UpdateExistingEmployee(Employee employee)
        {
            if (employee.EmployeeProjects == null || employee.EmployeeProjects.Count < 1)
                throw new ArgumentNullException("Project value cannot be null");
            _employeeRepository.Update(employee);
        }

    }
}
