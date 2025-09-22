using System;

namespace DPM225464_ThaiNgocQui_Pattern12_Proxy
{
    /// <summary>
    /// Proxy Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create proxy and request a service
            Proxy proxy = new Proxy();
            proxy.Request();
            // Wait for user
            Console.ReadKey();
        }
    }
}