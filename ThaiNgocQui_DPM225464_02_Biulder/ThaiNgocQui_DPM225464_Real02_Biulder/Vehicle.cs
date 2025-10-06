using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real02_Biulder
{
    class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType) => _vehicleType = vehicleType;

        public string this[string key]
        {
            get { return _parts.ContainsKey(key) ? _parts[key] : "N/A"; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Vehicle Type: {_vehicleType}");
            Console.WriteLine($" Frame  : {this["frame"]}");
            Console.WriteLine($" Engine : {this["engine"]}");
            Console.WriteLine($" #Wheels: {this["wheels"]}");
            Console.WriteLine($" #Doors : {this["doors"]}");
        }
    }
}
