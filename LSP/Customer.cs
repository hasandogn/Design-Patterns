using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Customer
    {
        public string Name { get;}
        public int Distance { get;}

        public Customer(string name, int distance)
        {
            Name = name;
            Distance = distance;
        }

        public void Call(Taxi taxi)
        {
            taxi.Take(this);
        }

        public void Pay(Taxi taxi)
        {
            Console.WriteLine("paying taxi " + taxi.Name);
        }
    }
}
