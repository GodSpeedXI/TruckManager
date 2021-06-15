using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTruckManager.Roles
{
    /// <summary>
    /// Who implement this role can do maintaining a truck
    /// and check a truck.
    /// </summary>
    public interface IMaintainerRole : ICanCheckStatus
    {
        void Fixing();
        void ChangeWheel(IWheel wheel, int wheelNumber);
    }
}
