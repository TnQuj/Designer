using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real14_Command
{
    public class CalculatorCommand : ICommand
    {
        private readonly Calculator _calculator;
        private readonly string _action;

        public CalculatorCommand(Calculator calculator, string action)
        {
            _calculator = calculator;
            _action = action;
        }

        public double Execute(double x, double y)
        {
            return _action switch
            {
                "+" => _calculator.Add(x, y),
                "-" => _calculator.Sub(x, y),
                "*" => _calculator.Mul(x, y),
                "/" => _calculator.Div(x, y),
                _ => 0
            };
        }
    }
}
