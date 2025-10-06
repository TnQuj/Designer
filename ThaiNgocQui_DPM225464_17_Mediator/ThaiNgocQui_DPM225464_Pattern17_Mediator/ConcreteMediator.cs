using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Pattern17_Mediator
{
    public class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 Colleague1 { get; set; }
        public ConcreteColleague2 Colleague2 { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Colleague1)
            {
                Colleague2.Notify(message);
            }
            else
            {
                Colleague1.Notify(message);
            }
        }
    }
}
