using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real17_Mediator
{
    public abstract class AirTrafficControlTower
    {
        public abstract void RegisterAircraft(Aircraft aircraft);
        public abstract void Send(string message, Aircraft aircraft);
    }
}
