using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real17_Mediator
{
    public class ConcreteAirTrafficControlTower : AirTrafficControlTower
    {
        private List<Aircraft> aircrafts = new List<Aircraft>();

        public override void RegisterAircraft(Aircraft aircraft)
        {
            if (!aircrafts.Contains(aircraft))
            {
                aircrafts.Add(aircraft);
            }
        }

        public override void Send(string message, Aircraft sender)
        {
            foreach (var ac in aircrafts)
            {
                if (ac != sender)
                {
                    ac.Receive(message);
                }
            }
        }
    }
}
