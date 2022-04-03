using _1_1_Singleton;
using _1_1_Singleton.LazySingleton;
using _1_1_Singleton.ThreadedLazySignleton;
using _1_1_Singleton.ThreadSafeLazySingleton;

public class Program
{
    public static void Main(string[] args)
    {
        // Normal Singleton *******************************************************

        //for (int i = 0; i < 10; i++)
        //{
        //    Singleton s = Singleton.Instance;
        //    s.PrintName();
        //}
        //Singleton s1 = Singleton.Instance;
        //Singleton s2 = Singleton.Instance;

        //if (s1 == s2)
        //{
        //    Console.WriteLine("Aynı Objeler");
        //}
        //else
        //    Console.WriteLine("Farklı Objeler");


        // Lazy Singleton *************************************************************
        //for (int i = 0; i < 10; i++)
        //{
        //    LazySingleton s = LazySingleton.Instance;
        //    s.PrintName();
        //}

        // ThreadedLazySingleton ********************************************************
        //Program client = new Program();
        //for (int i = 0; i < 100; i++)
        //{
        //    Thread thread = new Thread(new ThreadStart(client.Run));
        //    thread.Start();
        //}

        // Thread-Safe Singleton ****************************************
        Program client = new Program();
        for (int i = 0; i < 100; i++)
        {
            Thread thread = new Thread(new ThreadStart(client.Run));
            thread.Start();
        }

    }

    // ThreadedLazySingleton için oluşturuldu.
    public void Run()
    {
        ThreadedLazySingleton ls = ThreadedLazySingleton.Instance;
        ls.PrintName();
    }

    // ThreadSafeLazySingleton için oluşturuldu 
    public void Start()
    {
        ThreadSafeLazySingleton ls = ThreadSafeLazySingleton.Instance;
        ls.PrintName();
    }
}