using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Singleton.LazySingleton
{
    public class LazySingleton
    {
        // Bu durum nesnenin proje ayağa kaldırılırken değil, istediğimiz zaman üretelim için yapılır.

        // Direkt ilk sayırka new ile nesne açmayız, bunu static metotdaki get içerisinde if kontrolü ile ele alırız.
        private static LazySingleton singleton;

        private static int count;
        private readonly string name;

        //const private
        private LazySingleton()
        {
            count++;
            name = "LazySingleton" + count;
        }

        // Nesnenin oluşturulacağı yer
        public static LazySingleton Instance
        {
            get {
                // ************
                if(singleton == null)
                {
                    singleton = new LazySingleton();
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
