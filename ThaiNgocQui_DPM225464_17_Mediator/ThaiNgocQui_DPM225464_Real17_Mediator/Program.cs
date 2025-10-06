using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real17_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAirTrafficControlTower tower = new ConcreteAirTrafficControlTower();

            Boeing737 b737 = new Boeing737(tower, "Boeing 737");
            Airbus380 a380 = new Airbus380(tower, "Airbus 380");

            tower.RegisterAircraft(b737);
            tower.RegisterAircraft(a380);

            b737.Send("Requesting permission to land.");
            a380.Send("Runway clear, you may proceed.");

            Console.ReadKey();
        }
    }
}
