using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real19_Observer
{
    public class Investor : IInvestor
    {
        private string _name;
        private Stock stock;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"Notified {_name} of {stock.Symbol}'s change to {stock.Price:C}");
        }
    }
}
