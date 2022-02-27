using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingAndChoesionApp
{
    public class PrimitiveElevator
    {
        public bool DoorOpen { get; set; } = false;
        public int CurrentFloor { get; set; } = 1;
        public int Weight { get; set; } = 0;
        public readonly int CAPACITY = 1000;
        public readonly int TOP_FLOOR = 5;
        public readonly int BOTTOM_FLOOR = 1;

        public void openDoor()
        {
            if (!DoorOpen)
            {
                DoorOpen = true;
            }
            else
                Console.WriteLine("Door open already");
        }

        public void closeDoor()
        {
            calculateCapacity();
            if (Weight <= CAPACITY)
            {
                DoorOpen = false;
            }
            else
            {
                Console.WriteLine("The elevator has exceeded capacity. Somebody must get off!");
            }
        }

        public void goUp()
        {
            movement(1);
            //if (!DoorOpen)
            //{
            //    if (CurrentFloor < TOP_FLOOR)
            //    {
            //        CurrentFloor++;
            //        Console.WriteLine(CurrentFloor);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Already on top floor.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Doors still open");
            //}
        }

        public void goDown()
        {
            movement(-1);
            //if (!DoorOpen)
            //{
            //    if (CurrentFloor < TOP_FLOOR)
            //    {
            //        CurrentFloor--;
            //        Console.WriteLine(CurrentFloor);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Already on top floor.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Doors still open");
            //}
        }

        private void movement(int whereFloor)
        {
            if (!DoorOpen)
            {
                if (CurrentFloor < TOP_FLOOR)
                {
                    CurrentFloor = CurrentFloor + whereFloor;
                    Console.WriteLine(CurrentFloor);
                }
                else
                {
                    Console.WriteLine("Already on top floor.");
                }
            }
            else
            {
                Console.WriteLine("Doors still open");
            }
        }

        public void go(int desirefloor)
        {
            if ((desirefloor >= BOTTOM_FLOOR) && (desirefloor <= TOP_FLOOR))
            {
                while (CurrentFloor != desirefloor)
                {
                    if (CurrentFloor < desirefloor) goUp();
                    else goDown();
                }
            }
            else { Console.WriteLine("Invalid Floor"); }
        }
        private void calculateCapacity()
        {
            Random random = new Random();
            Weight = random.Next(1, 3000);
        }
    }
}
