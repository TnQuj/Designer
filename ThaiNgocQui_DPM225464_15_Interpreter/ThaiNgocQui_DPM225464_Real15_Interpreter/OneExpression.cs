using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real15_Interpreter
{
    public class OneExpression : Expression
    {
        public override void Interpret(Context context)
        {
            if (context.Input.StartsWith("IX"))
            {
                context.Output += 9;
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith("V"))
            {
                context.Output += 5;
                context.Input = context.Input.Substring(1);
            }
            else if (context.Input.StartsWith("IV"))
            {
                context.Output += 4;
                context.Input = context.Input.Substring(2);
            }

            while (context.Input.StartsWith("I"))
            {
                context.Output += 1;
                context.Input = context.Input.Substring(1);
            }
        }
    }
}
