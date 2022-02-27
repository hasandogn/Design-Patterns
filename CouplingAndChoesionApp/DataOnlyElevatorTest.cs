using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingAndChoesionApp
{
    public class DataOnlyElevatorTest
    {
        private static DataOnlyElevator PublicElvator = new DataOnlyElevator();

        public static void Main(string[] args)
        {
            // Eğer elevator ilk halindeki gibi ise testi böyle yazılır. Böyle manipüle ederiz. Böyle bir elevator'un cohesion'u çok yüksektir.
            // Burada anlaşılan cohesion'un data olarak anlamış gibi duruyor.
            // Biz cohesion derken davranış üzerinden bir cohesion'dan bahsediyoruz.
            // Burada enkapsüle etmek istemiş olsa bile datayı enkapsüle etmiş. Burada durum tabloya dönmüş.
            // Burada elevator aynı amaca hizmet eden field'lar desen bile biz burada data elementini modellemiyoruz. Entity Relationship yapısında entity
            // modelliyo olsak davranış yok cohesion'u çok yüksek, süper, topfloor 3te 5e de getirebilirim diyebilir.
            // Ama kaçırdığı bir nokta var. DAVRANIŞ NEREDE?
            // Burada sanki bir ip sarkıtılmış kendim çekiyorum gibi çünkü tüm davranışlar bende.
            // O yüzden (hiç bir davranış olmadığından) burada tüm bilgileri almak ve ona göre davranışı gerçekleştirmek client'a kalmış durumda.
            // Client sadece bilgi alıyor, fieldlara ulaşıyor ve diyorki kapıyı kapatıyorum, flooru arttırıyorum vs diyor.
            // Burada fieldlarda değişecek herhangi bir şey testi kıracaktır.
            // Ve sadece bilgi aldığımız için birlikte değişme problemi vardır.
            // Burada herhnagi bir message coupling yok, tamamen content coupling vardır.
            PrintElevatorState();
            PublicElvator.doorOpen = true;

            PublicElvator.doorOpen = false;
            PrintElevatorState();

            PublicElvator.currentFloor--;
            PublicElvator.currentFloor++;

            PublicElvator.currentFloor = 7;
            PublicElvator.doorOpen = true;

            PrintElevatorState();
            PublicElvator.doorOpen = false;

            PublicElvator.currentFloor = -15;
            PrintElevatorState(); 
            PublicElvator.doorOpen= true;
            PublicElvator.currentFloor++;
            PrintElevatorState();

        }

        public static void PrintElevatorState()
        {
            string doorStatusString = "CLOSED";
            if (PublicElvator.doorOpen)
                doorStatusString = "OPEN";

            Console.WriteLine("Elevator is at floot " + PublicElvator.currentFloor + "and the door " + doorStatusString);
        }
    }
}
