using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution2
{
    public class EmployeeFactory2 : Factory2
    {
        public Employee2 Create(string name)
        {
            Employee2 employee = new Employee2(EmployeeRandomizer.CreatId(), name, EmployeeRandomizer.CreateYear(), EmployeeRandomizer.CreateDepartment());
            return employee;
        }
    }
}
