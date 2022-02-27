using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingAndChoesionApp
{
    public class ResponsibleElevator : IResponsibleElevator
    {
        private bool doorOpen { get; set; } = false;
        private bool stopped { get; set; } = true;
        private Floor.FloorEnums currentFloor = Floor.FloorEnums.EXTRANCE;
        private int weight = 0;

        private readonly int CAPACITY = 1000;

        Floor floor;

        public void openDoor()
        {
            if (stopped)
                doorOpen = true;

            Console.WriteLine("Door is open");
        }

        public void closeDoor()
        {
            calculateCapacity();
            if (weight <= CAPACITY)
            {
                doorOpen = false;
                stopped = false;
                Console.WriteLine("Door is closed.");
            }
            else
                Console.WriteLine("The elevator has exceeded capacity, doors will remain open until someone exirs!");
        }

        public void goToFloor(Floor desiredFloor)
        {
            int compare = currentFloor.CompareTo(desiredFloor);
            while (compare != 0)
            {
                if (compare < 0)
                    goUp();
                else
                    goDown();
            }
            stopped = true;
            openDoor();
        }

        private void calculateCapacity()
        {
            Random random = new Random();
            weight = random.Next(1, 3000);
        }

        private void goUp()
        {
            if (!doorOpen)
            {
                closeDoor();
            }
            if (currentFloor.CompareTo(Floor.FloorEnums.FIFTH) < 0)
            {
                Console.WriteLine("Going up!");
                currentFloor = floor.increase();
                Console.WriteLine(currentFloor);
            }
            else
            {
                Console.WriteLine("Already pn top floor.");
            }
            stopped = true;
        }

        private void goDown()
        {
            if (doorOpen)
                closeDoor();
            if (currentFloor.CompareTo(Floor.FloorEnums.EXTRANCE) > 0)
            {
                Console.WriteLine("Going down.");
                currentFloor = floor.decrease();
                Console.WriteLine(currentFloor);
            }
            else
            {
                Console.WriteLine("Already on bottom floor.");
            }
            stopped = true;
        }

    }
}
