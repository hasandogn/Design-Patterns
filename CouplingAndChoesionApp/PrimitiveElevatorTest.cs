using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingAndChoesionApp
{
    public class PrimitiveElevatorTest
    {
        public static void Main(String[] args)
        {
            // 3. halinde
            // 2. hale (getter setter) göre çok çok daha iyi
            // Ama hala anlam bütünlüğü yok çünkü hareket ile alkalaı kaçıncı katta olduğu bilgisi istemciden isteniyor
            // Burada ayrıca kapı açma kapama durumu hala oto değil
            // -1000. kata gitmeye çalışmak için istek oluşturulabilir.
            PrimitiveElevator primitiveElevator = new PrimitiveElevator();

            primitiveElevator.openDoor();
            primitiveElevator.closeDoor();
            primitiveElevator.goDown();
            primitiveElevator.goUp();
            primitiveElevator.goUp();
            primitiveElevator.openDoor();
            primitiveElevator.closeDoor();
            primitiveElevator.goDown();
            primitiveElevator.openDoor();
            primitiveElevator.goDown();
            primitiveElevator.closeDoor();
            primitiveElevator.goDown();
            primitiveElevator.goDown();

            int currentFloor = primitiveElevator.CurrentFloor;

            if(currentFloor != 5 && !primitiveElevator.DoorOpen)
            {
                primitiveElevator.go(5);
            }

            primitiveElevator.go(-1000);
            primitiveElevator.openDoor();

        }
    }
}
