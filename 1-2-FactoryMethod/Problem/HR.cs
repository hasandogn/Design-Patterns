using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Problem
{
    public class HR
    {
        private List<Employee> employees = new List<Employee>();

        public HR()
        {
            Employee employee = new Employee(1, "Hasan", 10, "Production", "Employee");
            employees.Add(employee);
            employee = new Employee(2, "Hasan2", 11, "Sales", "Employee");
            employees.Add(employee);
            employee = new Employee(3, "Hasan3", 12, "Production", "Employee");
            employees.Add(employee);
            employee = new Employee(4, "Hasan4", 13, "Production", "Employee");
            employees.Add(employee);

            Employee manager = new Employee(20, "Yavuz", 10, "Marketing", "Manager", "Marketing");
            employees.Add(manager);
            new Employee(21, "Mehmet", 10, "Production", "Manager", "Production");
            employees.Add(manager);

            Employee director = new Employee(30, "Feyza", 15, "Company", "Director", "Company", 5000);
            employees.Add(manager);

        }

        public void AddNewEmployee(int no, string name, int year, string department, string type, string departmentManaged, double bonus)
        {
            Employee employee;
            switch (type)
            {
                case "Employee":
                    employee = new Employee(no, name, year, department, type);
                    employees.Add((employee));
                    break;

                case "Manager":
                    employee = new Employee(no, name, year, department, type, departmentManaged);
                    employees.Add(employee);
                    break;

                case "Director":
                    employee = new Employee(no, name, year, department, type, departmentManaged, bonus);
                    employees.Add(employee);
                    break;

            }
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public int GetNumberOfEmployees()
        {
            return (int)employees.Count;
        }
    }
}
