using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQSample
{
    public class EmployeeRepository
    {
        public IEnumerable<Employee> GetAll() {
            return _employees;
        }

        List<Employee> _employees = new List<Employee> {
            new Employee() { ID=1, Name="Anthony", DepartmentID=1 },
            new Employee() { ID=2, Name="Sheel", DepartmentID=1 },
            new Employee() { ID=3, Name="Claire", DepartmentID=2 },
            new Employee() { ID=4, Name="Zheng", DepartmentID=2 },
            new Employee() { ID=5, Name="Bill", DepartmentID=3 }
        };
    }
}
