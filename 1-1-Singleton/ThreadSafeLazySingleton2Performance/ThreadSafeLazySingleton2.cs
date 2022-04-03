using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Singleton.ThreadSafeLazySingleton2Performance
{
    public class ThreadSafeLazySingleton2
    {
        private static ThreadSafeLazySingleton2 singleton;

        // Thread Safe yapı için bir önceki lazy yapısındaki oluşacak performans sorunu için aşağıdaki yapıyı kullanırız. Lazy<>
        private static readonly Lazy<ThreadSafeLazySingleton2> instance = new Lazy<ThreadSafeLazySingleton2>(() => new ThreadSafeLazySingleton2());

        private static int count;
        private readonly string name;

        //const private
        private ThreadSafeLazySingleton2()
        {
            count++;
            name = "ThreadSafeLazySingleton2" + count;
        }

        // Nesnenin oluşturulacağı yer
        public static ThreadSafeLazySingleton2 Instance
        {
            get
            {
                // *****
                return instance.Value;
            }
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}
