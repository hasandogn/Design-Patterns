using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Equipment : Schedulable
    {
        public int getObjectId()
        {
            return 3;
        }

        public void notifyAboutActivity()
        {
            Console.WriteLine("Notification from an equipment.");
        }
    }
}
