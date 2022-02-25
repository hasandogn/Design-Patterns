using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee : Schedulable
    {
        public int getObjectId()
        {
            return 1;
        }

        public void notifyAboutActivity()
        {
            Console.WriteLine("Notification from an employee.");
        }
    }
}
