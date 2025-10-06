using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real14_Command
{
    public interface ICommand
    {
        double Execute(double x, double y);
    }
}
