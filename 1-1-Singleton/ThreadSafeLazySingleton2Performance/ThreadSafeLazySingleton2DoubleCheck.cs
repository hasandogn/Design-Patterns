using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Singleton.ThreadSafeLazySingleton2Performance
{
    public class ThreadSafeLazySingleton2DoubleCheck
    {
        private static ThreadSafeLazySingleton2DoubleCheck singleton;

        // Bu instance'nin get metotu içerisindeki locklı kontrolü sadece en ilk oluşacak bir kaç thread'ın içeri girip lock'ı bekleyip nesneyi yaratır ve böylece 
        // null kontolü artık geçmeyecek. Böylece diğer oluşacak yüzlerce thread normal kontrol ile yola devam edecekler ve if içerisine giremeyecekler.
        private static ThreadSafeLazySingleton2DoubleCheck instance;
        private static readonly object lockObject = new object();

        private static int count;
        private readonly string name;

        //const private
        private ThreadSafeLazySingleton2DoubleCheck()
        {
            count++;
            name = "ThreadSafeLazySingleton" + count;
        }

        // Nesnenin oluşturulacağı yer
        public static ThreadSafeLazySingleton2DoubleCheck Instance
        {
            get
            {
                // ************
                if (singleton == null)
                {
                    lock (lockObject)
                        if (singleton == null)
                            singleton = new ThreadSafeLazySingleton2DoubleCheck();

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
