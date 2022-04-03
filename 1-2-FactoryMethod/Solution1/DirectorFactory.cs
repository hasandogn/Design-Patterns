using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution1
{
    public class DirectorFactory : Factory
    {
        public Director Create()
        {
            Director director = new Director(EmployeeRandomizer.CreatId(), EmployeeRandomizer.CreatName(), EmployeeRandomizer.CreateYear(), "Management", "Management", 5000);
            return director;
        }
    }
}
