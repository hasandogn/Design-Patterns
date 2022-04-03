using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_FactoryMethod.Solution1
{
    public class EmployeeFactory : Factory
    {
        public Employee Create()
        {
            Employee employee = new Employee(EmployeeRandomizer.CreatId(), EmployeeRandomizer.CreatName(), EmployeeRandomizer.CreateYear(), EmployeeRandomizer.CreateDepartment());
            return employee;
        }
    }
}
