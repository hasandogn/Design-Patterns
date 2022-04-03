using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution3
{
    public class DirectorFactoryImpl : DirectorFactory3
    {
        public override Director3 Create(string name, string workingDepartment, int bonus)
        {
            Director3 director = new Director3(EmployeeRandomizer.CreatId(),
                                               name,
                                               EmployeeRandomizer.CreateYear(),
                                               workingDepartment,
                                               workingDepartment,
                                               bonus);

            return director;
        }
    }
}
