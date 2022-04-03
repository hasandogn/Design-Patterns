using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution1
{
    public class Employee
    {
        public int No { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public string DepartmentManagement { get; set; }
        public double Bonus { get; }

        public static readonly int BASE_SALARY = 500;
        public static readonly int MANAGEMENT_PAYMENT = 3000;

        public Employee(int no, string name, int year, string department)
        {
            this.No = no;
            this.Name = name;
            this.Year = year;
            this.Department = department;
        }

        public void Work()
        {
            Console.WriteLine("Employee is working!");
        }

        public double CalculateSalary()
        {
            Salary = Year * BASE_SALARY;
            return Salary;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("Employee Info");
            builder.Append("Type: Employee");

           
            builder.Append("No: " + No);
            builder.Append("Name: " + Name);
            builder.Append("Depatment: " + Department);
            builder.Append("Salary: " + CalculateSalary());

            return builder.ToString();
        }

    }
}
