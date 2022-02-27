using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingAndChoesionApp
{
    public class EncapsulatedElevatorTest
    {
        public static void main(String[] args)
        {
            // Burada tüm hareketleri kendisi yapıyor. Oyüzden herhangi bir bilgi sızıntısı yoktur.
            // Test içinde bu kadar rahat olabiliyoruz.
            EncapsulatedElevator encapsulated = new EncapsulatedElevator();

            encapsulated.openDoor();
            encapsulated.goDown();
            encapsulated.goUp();
            encapsulated.closeDoor();
            encapsulated.openDoor();
            encapsulated.goDown();
            encapsulated.goDown();
            encapsulated.goDown();
            encapsulated.goDown();
            encapsulated.goDown();
            encapsulated.go(Floor.FloorEnums.THIRD);
        }
    }
}
