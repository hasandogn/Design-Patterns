using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class BasbakanlikKalemi
    {
        private IBasbakan basbakan;
        public BasbakanlikKalemi(IBasbakan basbakan) {
            this.basbakan = basbakan;
        }

        public IBasbakan BanaBasbakaniVer()
        {
            Console.WriteLine("Basbakalik Kalemi: Tabi ki");
            return basbakan;
        }
    }
}


