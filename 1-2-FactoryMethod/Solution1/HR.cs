using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution1
{
    public class HR
    {
        private List<Employee> employees = new List<Employee>();

        public HR() { }

        public List<Employee> getEmployees()
        {
            return employees;
        }

        public int getNumberOfEmployees()
        {
            return employees.Count;
        }

        public void AddNewEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void listEmployee()
        {
            Console.WriteLine("All Employees");
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

    }
}
