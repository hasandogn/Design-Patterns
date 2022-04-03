using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution2
{
    public class HR2
    {
        private List<Employee2> employees = new List<Employee2>();

        public HR2() { }

        public List<Employee2> getEmployees()
        {
            return employees;
        }

        public int getNumberOfEmployees()
        {
            return employees.Count;
        }

        public void AddNewEmployee(Employee2 employee)
        {
            employees.Add(employee);
        }

        public void listEmployee()
        {
            Console.WriteLine("All Employees");
            foreach(Employee2 employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

    }
}
