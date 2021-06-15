using MyTruckManager.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTruckManager.Persons
{
    public class Cleaner
    {
        public void CleanATruck(ICleanerRole truckToClean) 
        {
            if (truckToClean.CheckDirty() <= 10 || truckToClean.TruckStatus == TruckStatus.Cleaning) 
            {
                Console.WriteLine("Cleaning...");
                Console.WriteLine($"Dirty Percent: { truckToClean.CheckDirty() }");
                Console.WriteLine($"Decline Percent: { truckToClean.CheckDecline() }");
                truckToClean.Cleaning();
                if (truckToClean.CheckDirty() == 100)
                {
                    truckToClean.TruckStatus = TruckStatus.None;
                }
                else 
                {
                    truckToClean.TruckStatus = TruckStatus.Cleaning;
                }
            }
        }
    }
}
