using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingAndChoesionApp
{
    public interface IResponsibleElevator
    {
        // Floor encapsulated ile aynısını kullanır.
        public void goToFloor(Floor.FloorEnums desiredFloor);
        public void openDoor();
        public void closeDoor();
    }
}
