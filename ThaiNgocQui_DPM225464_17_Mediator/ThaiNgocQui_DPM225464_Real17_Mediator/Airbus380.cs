using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real17_Mediator
{
    public class Airbus380 : Aircraft
    {
        public Airbus380(AirTrafficControlTower tower, string callSign)
            : base(tower, callSign) { }
    }
}
