using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_UpdatableSingleton
{
    public class UpdatableSingleton
    {
        private static UpdatableSingleton updatableSingleton = new UpdatableSingleton();

        private readonly IDictionary<string,int> products = new Dictionary<string,int>();
        private static readonly object lockObject = new object();

        private UpdatableSingleton()
        {
            products.Add("PC", 80);
            products.Add("tell", 46);
            products.Add("hat", 54);
        }

        private static UpdatableSingleton getInstance()
        {
            return updatableSingleton;
        }

        public void UpdateProduct(string threadName, string name, int price)
        {
            lock (lockObject)
            {
                Console.WriteLine(threadName + "**> Price for " + name + " before update: " + getPrice(name));
                products[name] = price;
                Console.WriteLine(threadName + "**> Price for " + name + " after update: " + getPrice(name));
            }
        }

        private int getPrice(string name)
        {
            return products[name];
        }

    }
}
