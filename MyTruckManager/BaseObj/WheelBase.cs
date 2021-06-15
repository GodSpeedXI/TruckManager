using System;
using MyTruckManager.Persons;
using MyTruckManager.Roles;

namespace MyTruckManager.BaseObj
{
    public class WheelBase : IWheel
    {
        private int _decline { get; set; } = 100;
        protected string WheelBrand;

        public void WheelsRun(Random declineFactor)
        {
            if(_decline > 10) _decline -= declineFactor.Next(1, 2);
            Console.WriteLine($"Wheel Brand Name: {WheelBrand}");
        }

        public string GetWheelBrandName()
        {
            return WheelBrand;
        }

        public WheelStatus WheelStatus {
            get
            {
                if (_decline < 10) return WheelStatus.Deprecated;
                return WheelStatus.Good;
            }
        }
    }
}