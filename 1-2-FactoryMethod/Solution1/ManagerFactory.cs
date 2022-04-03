using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution1
{
    public class ManagerFactory : Factory
    {

        public Manager Create()
        {
            string department = EmployeeRandomizer.CreateDepartment();
            Manager manager = new Manager(EmployeeRandomizer.CreatId(), EmployeeRandomizer.CreatName(), EmployeeRandomizer.CreateYear(), department, department);
            return manager;
        }
    }
}
