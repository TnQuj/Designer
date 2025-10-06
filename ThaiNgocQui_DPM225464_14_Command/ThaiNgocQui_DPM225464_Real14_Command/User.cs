using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real14_Command
{
    public class User
    {
        private readonly Calculator _calculator;

        public User(Calculator calculator)
        {
            _calculator = calculator;
        }

        public double Calculate(string action, double x, double y)
        {
            CalculatorCommand command = new CalculatorCommand(_calculator, action);
            return command.Execute(x, y);
        }
    }
}
