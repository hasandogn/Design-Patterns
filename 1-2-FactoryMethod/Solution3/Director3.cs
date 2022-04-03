using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution3
{
    internal class Director3
    {
        private int id;
        private string name;
        private int year;
        private string workingDepartment1;
        private string workingDepartment2;
        private int bonus;

        public Director3(int id, string name, int year, string workingDepartment1, string workingDepartment2, int bonus)
        {
            this.id = id;
            this.name = name;
            this.year = year;
            this.workingDepartment1 = workingDepartment1;
            this.workingDepartment2 = workingDepartment2;
            this.bonus = bonus;
        }
    }
}
