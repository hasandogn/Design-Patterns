using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution2
{
    public class ManagerFactory2 : Factory2
    {

        public Manager2 Create()
        {
            string department = EmployeeRandomizer.CreateDepartment();
            Manager2 manager = new Manager2(EmployeeRandomizer.CreatId(), EmployeeRandomizer.CreatName(), EmployeeRandomizer.CreateYear(), department, department);
            return manager;
        }
    }
}
