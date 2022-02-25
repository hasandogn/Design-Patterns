using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCoupling
{
    public class CutterFactory 
    {
       public ICutter createCutter () {
            ICutter cutter = null;

            Random random = new Random();  
            int classType = random.Next(1, 4);

            switch (classType) { 
                case 1:
                    cutter = new Barber();
                    break;
                case 2:
                    cutter= new Butcher();
                    break;
                case 3:
                    cutter= new Actor();
                    break;
            }
            return cutter;
       }
    }
}
