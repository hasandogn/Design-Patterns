using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Singleton
{
    public class Singleton
    {
        // Değişkeni private
        private static Singleton singleton = new Singleton();

        private static int count;
        private readonly string name;

        //const private
        private Singleton()
        {
            count++;
            name = "Singleton" + count; 
        }

        // Nesnenin oluşturulacağı yer
        public static Singleton Instance
        {
            get { return singleton; }
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}
