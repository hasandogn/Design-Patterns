using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingAndChoesionApp
{
    //public enum FloorEnums
    //{
    //    EXTRANCE = 0, FIRST = 1, SECOND = 2, THIRD = 3, FOURTH = 4, FIFTH = 5
    //}
    public class Floor
    {
        public enum FloorEnums { EXTRANCE = 0, FIRST = 1, SECOND = 2, THIRD = 3, FOURTH = 4, FIFTH = 5 };
        private int intFloor;

        private Floor(int intFloor)
        {
            this.intFloor = intFloor;
        }

        int getIntFloor()
        {
            return intFloor;
        }

        public FloorEnums increase()
        {
            FloorEnums upperFloor;

            if (intFloor == (int)FloorEnums.EXTRANCE)
                upperFloor = FloorEnums.FIRST;
            else if (intFloor == (int)FloorEnums.FIRST)
                upperFloor = FloorEnums.SECOND;
            else if (intFloor == (int)FloorEnums.SECOND)
                upperFloor = FloorEnums.THIRD;
            else if (intFloor == (int)FloorEnums.THIRD)
                upperFloor = FloorEnums.FOURTH;
            else 
                upperFloor = FloorEnums.FIFTH;

            return upperFloor;
        }

        public FloorEnums decrease()
        {
            FloorEnums upperFloor;

            if (intFloor == (int)FloorEnums.FIFTH)
                upperFloor = FloorEnums.FOURTH;
            else if (intFloor == (int)FloorEnums.FOURTH)
                upperFloor = FloorEnums.THIRD;
            else if (intFloor == (int)FloorEnums.THIRD)
                upperFloor = FloorEnums.SECOND;
            else if (intFloor == (int)FloorEnums.SECOND)
                upperFloor = FloorEnums.FIRST;
            else
                upperFloor = FloorEnums.EXTRANCE;

            return upperFloor;
        }

        public string toString()
        {
            string str = null;
            str = "Floor: " + getIntFloor();
            return str;
        }

    }
}
