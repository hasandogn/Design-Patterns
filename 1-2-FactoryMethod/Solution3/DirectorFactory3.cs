using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution3
{
    public interface DirectorFactory3
    {
        public Director3 Create(string name, string workingDepartment, int bonus);
    }
}
