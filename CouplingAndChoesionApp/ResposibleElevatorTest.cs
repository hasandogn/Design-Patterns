using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingAndChoesionApp
{
    public class ResposibleElevatorTest
    {
        public static void Main(string[] args)
        {
            IResponsibleElevator elevator = new ResponsibleElevator();
            elevator.openDoor();
            elevator.goToFloor(Floor.FloorEnums.FIFTH);
            elevator.openDoor();
            elevator.goToFloor(Floor.FloorEnums.FIRST);
            elevator.goToFloor(Floor.FloorEnums.FIFTH);

        }
    }
}
