using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Singleton.ThreadSafeLazySingleton
{
    public class ThreadSafeLazySingleton
    {
        private static ThreadSafeLazySingleton singleton;

        // Thread Safe yapı için muxed lock açılır. ve Instance get içerisinde if eklenir.
        // Javada synchronized kullnılır.
        private static ThreadSafeLazySingleton instance;
        private static readonly object lockObject = new object();

        private static int count;
        private readonly string name;

        //const private
        private ThreadSafeLazySingleton()
        {
            count++;
            name = "ThreadSafeLazySingleton" + count;
        }

        // Nesnenin oluşturulacağı yer
        public static ThreadSafeLazySingleton Instance
        {
            get
            {
                // ************
                lock (lockObject)
                    if (singleton == null)
                        singleton = new ThreadSafeLazySingleton();

                return singleton;
            }
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}
