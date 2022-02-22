// See https://aka.ms/new-console-template for more information

using ProxyPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vatandas basbakanlik kalemine gelir ve surec baslar.");

        IBasbakan basbakan = new GercekBasbakan();
        BasbakanlikKalemi basbakanlikKalemi = new BasbakanlikKalemi(basbakan);

        Vatandas hasan = new Vatandas(basbakanlikKalemi);

        hasan.DerdiniAnlat();
        hasan.IsIste();
    }
}
