using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Singleton.ThreadedLazySignleton
{
    public class ThreadedLazySingleton
    {
        // Burada singleton nesnesi Lazy ile aynı değişecek yer Client'dır. Nesnenin çağıralacağı yer.
        private static ThreadedLazySingleton singleton;

        private static int count;
        private readonly string name;

        //const private
        private ThreadedLazySingleton()
        {
            count++;
            name = "ThreadedLazySingleton" + count;
        }

        // Nesnenin oluşturulacağı yer
        public static ThreadedLazySingleton Instance
        {
            get
            {
                // ************
                if (singleton == null)
                {
                    singleton = new ThreadedLazySingleton();
                }
                return singleton;
            }
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}
