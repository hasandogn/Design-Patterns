using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_SingletonReflection
{
    public class EnumSingletonWrapper
    {
        public enum EnumSingleton
        {
            SINGLETON
        }

        private EnumSingletonWrapper()
        {

        }

        public static EnumSingleton Instance
        {
            get { return EnumSingleton.SINGLETON; }
        }

        public void PrintName()
        {
            Console.WriteLine(EnumSingleton.SINGLETON.ToString());
        }
    }
}
