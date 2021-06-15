using MyTruckManager.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTruckManager.Objects;

namespace MyTruckManager.Persons
{
    public class Maintainer
    {
        public void FixATruck(IMaintainerRole truckToFix) 
        {
            if (truckToFix.CheckDecline() <= 50 || truckToFix.TruckStatus == TruckStatus.Maintaining)
            {
                Console.WriteLine("Maintaining...");
                Console.WriteLine($"Dirty Percent: { truckToFix.CheckDirty() }");
                Console.WriteLine($"Decline Percent: { truckToFix.CheckDecline() }");
                truckToFix.Fixing();
                if (truckToFix.CheckDecline() == 100)
                {
                    truckToFix.TruckStatus = TruckStatus.None;
                }
                else
                {
                    truckToFix.TruckStatus = TruckStatus.Maintaining;
                }
            }

            if (truckToFix.Wheel1.WheelStatus == WheelStatus.Deprecated)
            {
                //truckToFix.TruckStatus = TruckStatus.Maintaining;
                truckToFix.ChangeWheel(ReplaceWheel(truckToFix.Wheel1), 1);
            }
            
            if (truckToFix.Wheel2.WheelStatus == WheelStatus.Deprecated)
            {
                //truckToFix.TruckStatus = TruckStatus.Maintaining;
                truckToFix.ChangeWheel(ReplaceWheel(truckToFix.Wheel2), 2);
            }
            
            if (truckToFix.Wheel3.WheelStatus == WheelStatus.Deprecated)
            {
                //truckToFix.TruckStatus = TruckStatus.Maintaining;
                truckToFix.ChangeWheel(ReplaceWheel(truckToFix.Wheel3), 3);
            }
            
            if (truckToFix.Wheel4.WheelStatus == WheelStatus.Deprecated)
            {
                //truckToFix.TruckStatus = TruckStatus.Maintaining;
                truckToFix.ChangeWheel(ReplaceWheel(truckToFix.Wheel4), 4);
            }

            if (truckToFix.Wheel1.WheelStatus == WheelStatus.Good
                && truckToFix.Wheel2.WheelStatus == WheelStatus.Good
                && truckToFix.Wheel3.WheelStatus == WheelStatus.Good
                && truckToFix.Wheel4.WheelStatus == WheelStatus.Good
                && truckToFix.TruckStatus == TruckStatus.Maintaining
            )
            {
                //truckToFix.TruckStatus = TruckStatus.None;
            }
        }

        private IWheel ReplaceWheel(IWheel wheel)
        {
            if (wheel.GetWheelBrandName() == "Michelin")
            {
                return new BridgeStone();
            }
            else
            {
                return new Michelin();
            }
        }
    }
}
