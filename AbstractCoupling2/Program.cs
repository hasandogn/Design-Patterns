using Polymorphism;
public class Program
{
    public static void Main(string[] args)
    {
        Schedulable schedulable = new Employee();
        schedulable.notifyAboutActivity();
        schedulable = new Equipment();
        schedulable.notifyAboutActivity();
        schedulable = new ConfRoom();
        schedulable.notifyAboutActivity();


    }
}