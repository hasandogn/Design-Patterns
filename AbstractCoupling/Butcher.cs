using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCoupling
{
    public class Butcher : ICutter
    {
        public virtual void Cut()
        {
            Console.WriteLine("I am a butcher");
        }
    }
}
