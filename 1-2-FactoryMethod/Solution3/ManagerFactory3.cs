using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution3
{
    public interface ManagerFactory3
    {
        public Manager3 Create(string name, string workingDepartment);
    }
}
