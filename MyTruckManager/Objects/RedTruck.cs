using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTruckManager.BaseObj;

namespace MyTruckManager.Objects
{
    public class RedTruck : TruckBase
    {
        public RedTruck()
        {
            truckColor = "RedTruck";

            Wheel1 = new Michelin();
            Wheel2 = new BridgeStone();
            Wheel3 = new Michelin();
            Wheel4 = new BridgeStone();
        }
    }
}
