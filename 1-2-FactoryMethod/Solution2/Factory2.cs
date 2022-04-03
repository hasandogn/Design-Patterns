using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution2
{
    public interface Factory2
    {
        public Employee2 Create(string name);
    }
}
