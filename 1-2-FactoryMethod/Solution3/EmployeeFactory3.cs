using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution3
{
    public interface EmployeeFactory3
    {
        public Employee3 Create(string name);
    }
}
