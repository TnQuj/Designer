using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real15_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context("MCMXXVIII");  // ví dụ La Mã "1928"

            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine($"{context.Input} = {context.Output}");

            Console.ReadKey();
        }
    }
}
