using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real02_Biulder
{
    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;
        public Vehicle Vehicle => vehicle;

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
