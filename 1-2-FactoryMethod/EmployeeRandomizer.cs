using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod
{
    public class EmployeeRandomizer
    {

        private static Random random = new Random();
        private static string[] depatments = { "Production", "Marketing", "Sales", "Engineering" };
        public static string CreatName()
        {
            Random random = new Random();
            int result = random.Next(0, 99999);
            return "Hasan" + result;
        }

        public static int CreateYear()
        {
            int result = random.Next(2000, 2025);
            return result;
        }
        public static int CreatId()
        {
            int result = random.Next(1, 100);
            return result;
        }

        public static string CreateDepartment()
        {
            string[] departments1 = { "Production", "Marketing", "Sales", "Engineering" };
            int result = random.Next(0, 4);
            return departments1[result].ToString();
        }
    }
}
