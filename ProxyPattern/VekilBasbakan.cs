using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class VekilBasbakan : IBasbakan
    {
        private IBasbakan gercekBasbakan;

        public VekilBasbakan(IBasbakan basbakan)
        {
            this.gercekBasbakan = gercekBasbakan;
        }
        public void DertDinle(string dert)
        {
            Console.WriteLine("Vekil: Derdinizi dinliyorum.");

            bool ayiklandi = Ayikla(dert);
            if (ayiklandi)
                Ilet(dert);
        }
        public void IsBul(string sorun)
        {
            Console.WriteLine("Vekil: Isteginizi dinliyorum.");
        }

        private void Ilet(string dert)
        {
            gercekBasbakan.DertDinle(dert);
        }

        private bool Ayikla(string dert)
        {
            bool b = true;
            return b;
        }

    }
}
