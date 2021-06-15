using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTruckManager.Roles
{
    /// <summary>
    /// Who implement this role can do driving a truck 
    /// and check a truck status.
    /// </summary>
    public interface IDriverRole : ICanCheckStatus
    {
        void Driving();
    }
}
