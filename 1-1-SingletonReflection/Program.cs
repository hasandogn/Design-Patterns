
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using _1_1_SingletonReflection;

public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            EnumSingletonWrapper.EnumSingleton singleton = EnumSingletonWrapper.EnumSingleton.SINGLETON;
            Console.WriteLine(singleton.ToString());
        }
        serializeSingleton();
    }

    static void serializeSingleton()
    {
        EnumSingletonWrapper.EnumSingleton singleton = EnumSingletonWrapper.EnumSingleton.SINGLETON;
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream("DOSYA YOLU", FileMode.Create);
        formatter.Serialize(stream, singleton);
        stream.Close();

        stream = new FileStream("AYNI DOSYA YOLU", FileMode.Open, FileAccess.Read);
        EnumSingletonWrapper.EnumSingleton anotherSingleton = (EnumSingletonWrapper.EnumSingleton)singleton;
        stream.Close();

        if (singleton == anotherSingleton)
            Console.WriteLine("Aynı Objeler.");
        else
            Console.WriteLine("Farklı objeler");
    }
}