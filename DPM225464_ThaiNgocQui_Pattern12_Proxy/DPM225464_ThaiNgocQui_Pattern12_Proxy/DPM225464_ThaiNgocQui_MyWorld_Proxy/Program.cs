using System;
namespace DPM225464_ThaiNgocQui_MyWorld_Proxy
{
    using static System.Console;
    using System.Threading;


    /// <summary>
    /// Proxy Design Pattern - Tính toán phương trình bậc 2
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            // Tạo proxy tính toán phương trình bậc 2
            var proxy = new MathProxy();

            // Nhập hệ số của phương trình bậc 2: ax^2 + bx + c = 0
            WriteLine("Nhập hệ số a: ");
            double a = double.Parse(ReadLine()!);

            WriteLine("Nhập hệ số b: ");
            double b = double.Parse(ReadLine()!);

            WriteLine("Nhập hệ số c: ");
            double c = double.Parse(ReadLine()!);

            // Tính nghiệm phương trình bậc 2
            var result = proxy.SolveQuadraticEquation(a, b, c);

            // In kết quả
            WriteLine(result);
            ReadKey();
        }
    }
}