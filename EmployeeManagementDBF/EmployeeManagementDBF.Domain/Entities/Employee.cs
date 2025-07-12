using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDBF.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
        public int DepartmentId { get; set; }
        public Department Departments { get; set; }
    }
}
