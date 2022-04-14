using Graduate_Program.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graduate_Program.Services.Services.Interfaces
{
    public interface IEmployeeInterface
    {
        Employee GetEmployeeById(int id);
        List<Employee> GetAllEmployees();
        public void AddNewEmployee(Employee employee);
        public void UpdateExistingEmployee(Employee employee);
        public void DeleteEmployee(int id);
    }
}
