using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real10_Facade
{
    public class Customer
    {
        private string name;
        public Customer(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }
    }
}
