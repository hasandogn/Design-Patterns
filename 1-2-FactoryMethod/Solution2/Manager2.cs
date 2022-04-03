using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution2
{
    public class Manager2
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

        public Manager2(int no, string name, int year, string department, string departmentManagement)
        {
            this.No = no;
            this.Name = name;
            this.Year = year;
            this.Department = department;
            this.DepartmentManagement = departmentManagement;
        }


        public void Work()
        {
            Manage();
        }

        public double CalculateSalary()
        {
            Salary = Year * BASE_SALARY + MANAGEMENT_PAYMENT;
            return Salary;
        }

        public void Manage()
        {
            Console.WriteLine("Manager manages department: " + DepartmentManagement);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("Employee Info");
            builder.Append("Type: Manager");

            builder.Append("No: " + No);
            builder.Append("Name: " + Name);
            builder.Append("Depatment: " + Department);
            builder.Append("Salary: " + CalculateSalary());

            builder.Append("Manages: " + DepartmentManagement);

            return builder.ToString();
        }
    }
}
