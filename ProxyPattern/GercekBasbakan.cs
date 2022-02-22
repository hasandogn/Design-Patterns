using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class GercekBasbakan : IBasbakan
    {
        public void DertDinle(string dert)
        {
            Console.WriteLine("Basbakan: dinliyorum");
        }

        public void IsBul(string sorun)
        {
            Console.WriteLine("Basbakan: Bana boyle isteklerle gelmeyin.");
        }
    }
}
