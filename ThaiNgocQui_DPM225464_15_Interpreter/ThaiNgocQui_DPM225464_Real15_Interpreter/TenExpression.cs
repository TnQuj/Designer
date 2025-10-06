using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real15_Interpreter
{
    public class TenExpression : Expression
    {
        public override void Interpret(Context context)
        {
            if (context.Input.StartsWith("XC"))
            {
                context.Output += 90;
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith("L"))
            {
                context.Output += 50;
                context.Input = context.Input.Substring(1);
            }
            else if (context.Input.StartsWith("XL"))
            {
                context.Output += 40;
                context.Input = context.Input.Substring(2);
            }

            while (context.Input.StartsWith("X"))
            {
                context.Output += 10;
                context.Input = context.Input.Substring(1);
            }
        }
    }
}
