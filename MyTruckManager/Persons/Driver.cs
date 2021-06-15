using MyTruckManager.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTruckManager.Persons
{
    public class Driver
    {
        public void DriveATruck(IDriverRole drive) 
        {
            if (drive.CheckDirty() > 10 
                && drive.CheckDecline() > 50 
                && (drive.TruckStatus == TruckStatus.None 
                || drive.TruckStatus == TruckStatus.Driving))
            {
                Console.WriteLine("Driving...");
                Console.WriteLine($"Driver driving: {drive.GetTruckColor()}");
                Console.WriteLine($"Dirty Percent: { drive.CheckDirty() }");
                Console.WriteLine($"Decline Percent: {drive.CheckDecline()}");
                drive.Driving();
                if (drive.CheckDirty() < 10
                && drive.CheckDecline() < 50)
                {
                    Console.Clear();
                    drive.TruckStatus = TruckStatus.None;
                }
                else 
                {
                    drive.TruckStatus = TruckStatus.Driving;
                }
            }
            else 
            {
                Console.WriteLine("Driver StopDriving...");
            }
            
        }
    }
}
