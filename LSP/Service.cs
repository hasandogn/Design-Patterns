using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Service
    {
        public string description = "Destination arrived!";

        public override string ToString()
        {
            return "Service [description=]" + description + "]";
        }
    }
}
