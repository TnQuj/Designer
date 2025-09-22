using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225464_ThaiNgocQui_MyWorld_Proxy
{
    public class MathProxy : IMath
    {
        private readonly Math math = new();

        public string SolveQuadraticEquation(double a, double b, double c)
        {
            // Giả lập độ trễ trong việc tính toán
            Thread.Sleep(800);
            return math.SolveQuadraticEquation(a, b, c);
        }
    }
}
