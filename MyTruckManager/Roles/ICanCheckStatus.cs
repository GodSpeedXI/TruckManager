using MyTruckManager.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTruckManager.Roles
{
    /// <summary>
    /// Who implement this role can do check a truck status.
    /// </summary>
    public interface ICanCheckStatus
    {
        TruckStatus TruckStatus { get; set; }
        int CheckDirty();
        int CheckDecline();
        string GetTruckColor();

        // WheelStatus CheckWheel_1();
        // WheelStatus CheckWheel_2();
        // WheelStatus CheckWheel_3();
        // WheelStatus CheckWheel_4();
        
        IWheel Wheel1 { get; }
        IWheel Wheel2 { get; }
        IWheel Wheel3 { get; }
        IWheel Wheel4 { get; }
    }
}
