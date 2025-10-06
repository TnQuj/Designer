using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real13_ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            Purchase p1 = new Purchase(2034, 350.00, "Supplies");
            larry.ProcessRequest(p1);

            Purchase p2 = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p2);

            Purchase p3 = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p3);

            Console.ReadKey();
        }
    }
}
