using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingAndChoesionApp
{
    public class GetterSetterElevator
    {// Getter  setter hali ile
        public bool DoorOpen { get; set; } = false;
        public int CurrentFloor { get; set; } = 1;
        public int Weight { get; set; } = 0;

        public readonly int CAPACITY = 1000;
        public readonly int TOP_FLOOR = 5;
        public readonly int BOTTOM_FLOOR = 1;
    }
}
