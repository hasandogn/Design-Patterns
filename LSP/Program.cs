using LSP;

public class Program
{
    public static void Main(string[] args)
    {
        // Burada checkConditation metodunda özelleştirme yapıldı. LSP ye uygun şekidle. 
        // Alt ve üst tiplerin bilinemsine gerek kalmadan halledebiliyoruz

        Customer customer1 = new Customer("Hasan", 200);
        Taxi taxi = new Taxi("Akasya");
        customer1.Call(taxi);
        Service service = taxi.service();
        Console.WriteLine(service);


        Customer customer2 = new Customer("Hasan2", 12000);
        Taxi vipTaxi = new VipTaxi("Akasya");
        customer1.Call(vipTaxi);
        Service vipService = vipTaxi.service();
        Console.WriteLine(vipService);

    }
}