using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Pattern20_State
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
