using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class VipTaxi : Taxi
    {
        public VipTaxi(string str): base(str)
        {

        }

        public bool chechPrecondition(Customer customer)
        {
            return true;
        }

        public VipService service()
        {
            return new VipService();
        }
    }
}
