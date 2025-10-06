using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real18_Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;

            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            // change state
            s.Name = "Doc Brown";
            s.Phone = "(123) 456-7890";
            s.Budget = 1000000.0;

            // restore
            s.RestoreMemento(m.Memento);

            Console.WriteLine("Restored: ");
            Console.WriteLine($"Name: {s.Name}");
            Console.WriteLine($"Phone: {s.Phone}");
            Console.WriteLine($"Budget: {s.Budget}");

            Console.ReadKey();
        }
    }
}
