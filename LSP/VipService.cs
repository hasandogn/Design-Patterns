using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class VipService : Service
    {
        private string vipDescription = "Wifi provided! ";

        public override string ToString()
        {
            return "Service [description=]" + vipDescription +" "+ description + "]";
        }
    }
}
