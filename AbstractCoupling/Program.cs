using AbstractCoupling;
public class Program
{
    public static void Main(string[] args)
    {
        CutterFactory factory = new CutterFactory();

        for(int i = 0 ; i < 5 ; i++)
        {
            factory.createCutter().Cut();
        }
    }
}