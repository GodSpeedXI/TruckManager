using System;
using MyTruckManager.Persons;
using MyTruckManager.Roles;

namespace MyTruckManager.BaseObj
{
    public class TruckBase : IDriverRole, ICleanerRole, IMaintainerRole
    {
        private Random random;
        private int _decline { get; set; } = 100;
        private int _dirty { get; set; } = 100;
        protected string truckColor;
        
        public IWheel Wheel1 { get; set; }
        public IWheel Wheel2 { get; set; }
        public IWheel Wheel3 { get; set; }
        public IWheel Wheel4 { get; set; }
        TruckStatus ICanCheckStatus.TruckStatus { get; set; } = TruckStatus.None;

        public TruckBase(int luck = 30)
        {
            random = new Random(luck);
        }

        /// <summary>
        /// When driver is driving, the truck will be gradually declined.
        /// </summary>
        public void Driving()
        {
            DirtyRolling();
            DeclineRolling();
        }

        /// <summary>
        /// Gradually dirty the truck.
        /// </summary>
        private void DirtyRolling() 
        {
            _dirty -= random.Next(1, 10);
        }
        
        /// <summary>
        /// Gradually decline the truck.
        /// </summary>
        private void DeclineRolling() 
        {
            _decline -= random.Next(1, 5);
            
            Wheel1.WheelsRun(random);
            Wheel2.WheelsRun(random);
            Wheel3.WheelsRun(random);
            Wheel4.WheelsRun(random);
        }

        /// <summary>
        /// Do check truck dirty.
        /// </summary>
        /// <returns></returns>
        public int CheckDirty()
        {
            return _dirty;
        }

        public string GetTruckColor()
        {
            return truckColor;
        }

        public int CheckDecline()
        {
            return _decline;
        }

        public WheelStatus CheckWheel_1()
        {
            return Wheel1.WheelStatus;
        }
        public WheelStatus CheckWheel_2()
        {
            return Wheel2.WheelStatus;
        }
        public WheelStatus CheckWheel_3()
        {
            return Wheel3.WheelStatus;
        }
        public WheelStatus CheckWheel_4()
        {
            return Wheel4.WheelStatus;
        }

        public void ChangeWheel(IWheel wheel, int wheelNumber)
        {
            switch (wheelNumber)
            {
                case 1:
                    Wheel1 = wheel;
                    break;
                case 2:
                    Wheel2 = wheel;
                    break;
                case 3:
                    Wheel3 = wheel;
                    break;
                case 4:
                    Wheel4 = wheel;
                    break;
            }
        }

        public void Cleaning()
        {
            if ((_dirty + 5) > 100)
            {
                _dirty = 100;
            }
            else 
            {
               _dirty += 5;
            }
            
        }

        public void Fixing()
        {
            if ((_decline + 5) > 100)
            {
                _decline = 100;
            }
            else
            {
                _decline += 5;
            }
        }
        
    }
}
