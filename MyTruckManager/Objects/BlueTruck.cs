using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTruckManager.BaseObj;

namespace MyTruckManager.Objects
{
    public class BlueTruck : TruckBase
    {
        public BlueTruck() : base(50)
        {
            truckColor = "BlueTruck";

            Wheel1 = new Michelin();
            Wheel2 = new Michelin();
            Wheel3 = new Michelin();
            Wheel4 = new Michelin();
        }
    }
}
