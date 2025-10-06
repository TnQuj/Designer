using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real18_Memento
{
    public class ProspectMemento
    {
        public string Name { get; }
        public string Phone { get; }
        public double Budget { get; }

        public ProspectMemento(string name, string phone, double budget)
        {
            Name = name;
            Phone = phone;
            Budget = budget;
        }
    }
}
