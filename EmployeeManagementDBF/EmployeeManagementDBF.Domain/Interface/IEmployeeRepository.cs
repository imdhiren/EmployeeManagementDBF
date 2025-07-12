using EmployeeManagementDBF.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDBF.Domain.Interface
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        Employee Add(Employee employee);
        Employee Update(Employee employee); 
        Employee Delete(Employee employee);
        IEnumerable<Employee> GetByDepartmentID(int departmentID);
    }
}
