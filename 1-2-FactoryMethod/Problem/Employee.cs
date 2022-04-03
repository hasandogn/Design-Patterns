using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod
{
    public class Employee
    {

        // Burada metotlar type'a göre farklı çeşitlerde çalışıyor. BU durum aslında sıkıntı olsa da Factory bunun için işlem yapmıyor.
        // Factory Method'un çözümü HR sınıfında da göreceğin gibi type'a göre işlem yapılmasıdır. Employee mi ekleyecek, Manager mi, yoksa Director mü? 
        // Çünkü tipe göre constructurlar değişecek
        // Burada da görüleceği üzere, Employee'i kullanmak farklı; oluşturmak ve kullanmak farklı bir şey.
        // HR'ın, Employee nesnelerinin sadece arayüzlerini değil aynı zamanda nasıl yaratacaklarını da bilmesi, HR'ın Employee'lere olan bağımlılığını arttırır
        public int No { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public string Type { get; }
        public string DepartmentManagement { get; set; }
        public double Bonus { get; }

        public static readonly int BASE_SALARY = 500;
        public static readonly int MANAGEMENT_PAYMENT = 3000;
        private int id;

        public Employee(int no, string name, int year, string department, string type)
        {
            this.No = no;
            this.Name = name;
            this.Year = year;
            this.Department = department;
            this.Type = type;
        }
        public Employee(int no, string name, int year, string department, string type, string departmentManagement)
        {
            this.No = no;
            this.Name = name;
            this.Year = year;
            this.Department = department;
            this.Type = type;
            this.DepartmentManagement = departmentManagement;
        }

        public Employee(int no, string name, int year, string department, string type, string departmentManagement, double bonus)
        {
            this.No = no;
            this.Name = name;
            this.Year = year;
            this.Department = department;
            this.Type = type;
            this.DepartmentManagement = departmentManagement;
            this.Bonus = bonus;
        }

        public Employee(int id, string name, int year, string department)
        {
            this.id = id;
            Name = name;
            Year = year;
            Department = department;
        }

        public void Work()
        {
            if (Type.Equals("Director"))
            {
                Manage();
                MakeAStrategicPlan();
            }
            else if (Type.Equals("Manager"))
            {
                Manage();
            }
            else
                Console.WriteLine("Employee is working!");
        }

        public double CalculateSalary()
        {
            switch (Type)
            {
                case "Employee":
                    Salary = Year * BASE_SALARY;
                    break;

                case "Manager":
                    Salary = Year * BASE_SALARY + MANAGEMENT_PAYMENT;
                    break;

                case "Director":
                    Salary = Year * BASE_SALARY + MANAGEMENT_PAYMENT + Bonus;
                    break;
            }

            return Salary;
        }

        public void Manage()
        {
            if (Type.Equals("Director"))
                Console.WriteLine("Director manages whole company!");
            else if (Type.Equals("Manager"))
                Console.WriteLine("Manager manages department: " + DepartmentManagement);
            else
                Console.WriteLine("I am jsut a poor Employee and can only manage myself!");
        }

        public void MakeAStrategicPlan()
        {
            if(Type.Equals("Director"))
                Console.WriteLine("Director makes a strategic plan for the company!");
            else
                Console.WriteLine("I am not a Director and cant make any strategic plan!");
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("Employee Info");
            builder.Append("Type: " + Type);

            if (Type.Equals("Director"))
                builder.Append("Director of the company!");
            builder.Append("No: " + No);
            builder.Append("Name: " + Name);
            builder.Append("Depatment: " + Department);
            builder.Append("Salary: " + CalculateSalary());

            if (Type.Equals("Manager"))
                builder.Append("Manages: " + DepartmentManagement);

            return builder.ToString();
        }

    }

}
