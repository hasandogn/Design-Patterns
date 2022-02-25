using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class ConfRoom : Schedulable
    {
        public int getObjectId()
        {
            return 2;
        }

        public void notifyAboutActivity()
        {
            Console.WriteLine("Notification from an conferance.");
        }
    }
}
