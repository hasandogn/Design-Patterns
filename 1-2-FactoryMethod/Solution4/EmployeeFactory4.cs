using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution4
{
    public class EmployeeFactory4
    {
        public static Employee create(string type)
        {
            // Bu kod ocp'YE DE srp'YE DE UYGUN DEĞİL.
            Employee employee = null;
            int id = EmployeeRandomizer.CreatId();
            string name = EmployeeRandomizer.CreatName();
            int year = EmployeeRandomizer.CreateYear();

            string department = EmployeeRandomizer.CreateDepartment();
            switch (type)
            {
                case "Employee":
                    employee = new Employee(id, name, year, department);
                    break;
                case "Manager":
                    employee = new Employee(id, name, year, department, department);
                    break;
                case "Director":
                    employee = new Employee(id, name, year, "Management", "Management", 5000);
                    break;

            }

            return employee;
        }
    }
}
