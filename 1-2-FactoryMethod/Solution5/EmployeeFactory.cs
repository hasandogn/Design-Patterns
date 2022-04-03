using _1_2_FactoryMethod.Solution1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution5
{
    public class EmployeeFactory
    {

        public static Employee createEmployee(string name)
        {
            Employee employee = null;
            Random random = new Random();
            int id = random.Next(0, 100);
            int year = random.Next(2000, 2060);
            String department = "Random" + id + year;
            employee = new Employee(id,name,year,department);
            return employee;
        }

        public static Manager contextManager(string name, string department)
        {
            Manager manager = null;
            Random random = new Random();
            int id = random.Next(0, 100);
            int year = random.Next(2000, 2060);
            manager = new Manager(id,name, year, department, department);
            return manager;
        }

        public static Director createDirector(string name, string department, int bonus)
        {
            Director director = null;
            Random random = new Random();
            int id = random.Next(0, 100);
            int year = random.Next(2000, 2060);
            director = new Director(id,name,year, "Management", "Management", bonus);
            return director;
        }
    }
}
