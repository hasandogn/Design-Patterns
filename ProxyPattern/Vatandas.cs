using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Vatandas
    {
        private IBasbakan basbakan;

        public Vatandas(BasbakanlikKalemi basbakanlikKalemi)
        {
            basbakan = basbakanlikKalemi.BanaBasbakaniVer();
        }

        public string DerdiniAnlat()
        {
            basbakan.DertDinle("Bir derdim var...");
            return "Dinledi gerçekten";
        }

        public string IsIste()
        {
            basbakan.IsBul("Oglum");
            return "Dinledi Gercekten";
        }
    }
}
