using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_BillPughForSignleton
{
    public class BillPughSingleton
    {
        private static int count;
        public string Name { get; }

        private BillPughSingleton()
        {
            Name = "BillPughSingleton" + count++;
        }

        private static class SingletonHelper
        {
            public static readonly BillPughSingleton instance = new BillPughSingleton();
        }

        public void printName()
        {
            Console.WriteLine(Name);
        }

        public static BillPughSingleton getInstance()
        {
            return SingletonHelper.instance;
        }
    }
}
