using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SimpleEmployeeQueries();
        }

        private static void SimpleEmployeeQueries() {
            var query1 =
                from e in new EmployeeRepository().GetAll()
                where e.DepartmentID < 3 && e.ID < 10
                orderby e.DepartmentID descending,
                        e.Name ascending
                select e;
            Write(query1);

            var query2 =
                new EmployeeRepository().GetAll()
                    .Where(e => e.DepartmentID < 3 && e.ID < 10)
                    .OrderByDescending(e => e.DepartmentID)
                    .ThenBy(e => e.Name);
            Write(query2);
        }

        static void Write(IEnumerable<Employee> employees) {

            foreach (Employee e in employees) {
                Console.WriteLine(e.Name);
            }
            Console.WriteLine();
        }

    }
}
