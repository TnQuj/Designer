using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThaiNgocQui_DPM225464_Pattern20_State;

namespace ThaiNgocQui_DPM225464_Pattern20_State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Setup context in a state
            var context = new Context(new ConcreteStateA());
            // Issue requests, which toggles state
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            // Wait for user
            Console.ReadKey();
        }
    }
}
