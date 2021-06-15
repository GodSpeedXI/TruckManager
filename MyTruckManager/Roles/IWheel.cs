using System;
using MyTruckManager.Persons;

namespace MyTruckManager.Roles
{
    public interface IWheel
    {
        WheelStatus WheelStatus { get; }
        void WheelsRun(Random declineFactor);
        string GetWheelBrandName();
    }
}