using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Pattern11_Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicState = 22;

            FlyweightFactory factory = new FlyweightFactory();

            // Work with different flyweight instances
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicState);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicState);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicState);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicState);

            Console.ReadKey();
        }
    }
}
