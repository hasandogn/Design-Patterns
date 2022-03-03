using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Taxi
    {
        public string Name { get; }
        protected Customer customer { get; set; }

        public Taxi(string name)
        {
            Name = name;
        }

        public bool Take(Customer customer)
        {
            if (checkPrecondition(customer))
            {
                this.customer = customer;
                return true;
            }
            else 
                return false;
        }

        private bool checkPrecondition(Customer customer)
        {
            if (customer.Distance < 1000)
            {
                return true;
            }
            else
                return false;
        }

        public Service service()
        {
            return new Service();
        }
    }
}
