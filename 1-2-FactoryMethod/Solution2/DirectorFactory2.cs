using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution2
{
    public class DirectorFactory2 : Factory2
    {
        public override Director2 Create()
        {
            Director2 director = new Director2(EmployeeRandomizer.CreatId(), EmployeeRandomizer.CreatName(), EmployeeRandomizer.CreateYear(), "Management", "Management", 5000);
            return director;
        }
    }
}
