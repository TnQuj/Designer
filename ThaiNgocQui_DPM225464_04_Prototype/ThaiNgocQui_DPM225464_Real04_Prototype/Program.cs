using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real04_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors
            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors
            Color c1 = colormanager["red"].Clone() as Color;
            Color c2 = colormanager["peace"].Clone() as Color;
            Color c3 = colormanager["flame"].Clone() as Color;

            Console.WriteLine("Cloned colors:");
            Console.WriteLine($"c1: {c1}");
            Console.WriteLine($"c2: {c2}");
            Console.WriteLine($"c3: {c3}");

            Console.ReadKey();
        }
    }
}
