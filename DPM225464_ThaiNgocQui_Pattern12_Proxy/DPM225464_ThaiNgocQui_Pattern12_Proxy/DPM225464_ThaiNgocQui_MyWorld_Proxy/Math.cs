using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225464_ThaiNgocQui_MyWorld_Proxy
{
    public class Math : IMath
    {
        public string SolveQuadraticEquation(double a, double b, double c)
        {
            // Kiểm tra a có phải là 0 không, vì phương trình sẽ không phải bậc 2 nếu a = 0
            if (a == 0)
            {
                return "Phương trình không phải phương trình bậc 2 vì a = 0.";
            }

            // Tính delta
            double delta = b * b - 4 * a * c;

            // Tính nghiệm phương trình bậc 2
            if (delta > 0)
            {
                double x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);

                double x2 = (-b - System.Math.Sqrt(delta)) / (2 * a);
                return $"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return $"Phương trình có nghiệm kép: x = {x}";
            }
            else
            {
                return "Phương trình vô nghiệm.";
            }
        }
    }
}
