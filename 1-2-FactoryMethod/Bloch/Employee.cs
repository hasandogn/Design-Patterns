using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Bloch
{
    public class Employee
    {
        public int no { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public string  department { get; set; }
        public double salary { get; set; }

        public static readonly int BASE_SALARY = 500;

        private Employee(int no, string name, int year, string department)
        {
            this.no = no;
            this.department = department;
            this.name = name;
            this.year = year;

        }

        public static Employee CreateNewEmployee(int no, string name, string department)
        {
            return new Employee(no, name, 0, department);
        }

        public static Employee CreateNewTemporaryEmployee(int no, string name)
        {
            return new Employee(no, name, 0, "Temp");
        }

        public virtual void Work()
        {
            Console.WriteLine("Employee is working!");
        }

        public virtual double CalculateSalary()
        {
            salary = year * BASE_SALARY;
            return salary;
        }

    }
}
