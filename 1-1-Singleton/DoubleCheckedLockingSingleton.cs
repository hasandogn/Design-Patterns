using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Singleton
{
    public class DoubleCheckedLockingSingleton
    {
        // Bu instance'nin get metotu içerisindeki locklı kontrolü sadece en ilk oluşacak bir kaç thread'ın içeri girip lock'ı bekleyip nesneyi yaratır ve böylece 
        // null kontolü artık geçmeyecek. Böylece diğer oluşacak yüzlerce thread normal kontrol ile yola devam edecekler ve if içerisine giremeyecekler.
        //private static DoubleCheckedLockingSingleton singleton;

        // Yukarıdaki gibi bir belişrleme de ise bazen thread oluşurken lock içerisimmde singleton'un null ypaabiliyor ve thread'ların tekrar içlerine girme durumu olabiliyor
        // Bu durum içinde volatile keywordunu kullanıyoruz.
        private static volatile DoubleCheckedLockingSingleton singleton;

        // Ayrıca volatile keywordunu normal static metot ya da değişkenler içinde kullanabiliriz. Aynı değişkeni farklı threadler kullandığında
        // Aaynı sorun oluşacaktır.



        private static readonly object lockObject = new object();

        private static int count;
        private readonly string name;

        //const private
        private DoubleCheckedLockingSingleton()
        {
            count++;
            name = "ThreadSafeLazySingleton" + count;
        }

        // Nesnenin oluşturulacağı yer
        public static DoubleCheckedLockingSingleton Instance
        {
            get
            {
                // ************
                if (singleton == null)
                {
                    lock (lockObject)
                        if (singleton == null)
                            singleton = new DoubleCheckedLockingSingleton();

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
