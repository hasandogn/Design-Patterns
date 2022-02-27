using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingAndChoesionApp
{
    public class EncapsulatedElevator
    {
        // Burada kapı açıksa, kapıyı kapatıyor ve beklemiyor herhangi bir şey.
        // Ayrıca burada go metodun -1000... geçicek şekilde bir tip koymamışım, floor koymuşum ve enumeration bu floor tipine baktığı zaman
        private bool DoorOpen { get; set; } = false;
        private bool Stopped { get; set; } = true;
        private Floor.FloorEnums CurrentFloor { get; set; } = Floor.FloorEnums.EXTRANCE;
        private int Weight { get; set; } = 0;
        private readonly int CAPACITY = 1000;
        //private readonly int TOP_FLOOR = 5;
        //private readonly int BOTTOM_FLOOR = 1;

        private Floor floor;
        public void openDoor()
        {
            if (Stopped)
            {
                DoorOpen = true;
            }
            Console.WriteLine("Door is open.");
        }

        public void closeDoor()
        {
            calculateCapacity();
            if (Weight <= CAPACITY)
            {
                DoorOpen = false;
                Stopped = false;
                Console.WriteLine("Door is closed");
            }
            else
                Console.WriteLine("The elevator has exceeded capacity, doors will remain open until someone exits!");
        }

        private void calculateCapacity()
        {
            Random random = new Random();
            Weight = random.Next(1, 3000);
        }

        public void goUp()
        {
            if (!DoorOpen)
            {
                closeDoor();
            }
            if (CurrentFloor.CompareTo(Floor.FloorEnums.FIFTH) < 0)
            {
                Console.WriteLine("Going up!");
                CurrentFloor = floor.increase();
                Console.WriteLine(CurrentFloor);
            }
            else
            {
                Console.WriteLine("Already pn top floor.");
            }
            Stopped = true;
        }

        public void goDown()
        {
            if (DoorOpen)
                closeDoor();
            if (CurrentFloor.CompareTo(Floor.FloorEnums.EXTRANCE) > 0)
            {
                Console.WriteLine("Going down.");
                CurrentFloor = floor.decrease();
                Console.WriteLine(CurrentFloor);
            }
            else
            {
                Console.WriteLine("Already on bottom floor.");
            }
            Stopped=true;
        }

        public void go(Floor.FloorEnums desiredFloor)
        {
            int compare = CurrentFloor.CompareTo(desiredFloor);
            while(compare != 0)
            {
                if(compare < 0) 
                    goUp();
                else 
                    goDown();
                compare = CurrentFloor.CompareTo(desiredFloor);
            }
            Stopped = true;
            openDoor();
        }

        public Boolean getDoorStatus()
        {
            return DoorOpen;
        }
    }
}
