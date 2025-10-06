using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real15_Interpreter
{
    public class HundredExpression : Expression
    {
        public override void Interpret(Context context)
        {
            if (context.Input.StartsWith("CM"))
            {
                context.Output += 900;
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith("D"))
            {
                context.Output += 500;
                context.Input = context.Input.Substring(1);
            }
            else if (context.Input.StartsWith("CD"))
            {
                context.Output += 400;
                context.Input = context.Input.Substring(2);
            }

            while (context.Input.StartsWith("C"))
            {
                context.Output += 100;
                context.Input = context.Input.Substring(1);
            }
        }
    }
}
