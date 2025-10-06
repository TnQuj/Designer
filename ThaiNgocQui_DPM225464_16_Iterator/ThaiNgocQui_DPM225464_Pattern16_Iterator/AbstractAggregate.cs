using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Pattern16_Iterator
{
    public abstract class AbstractAggregate
    {
        public abstract Iterator CreateIterator();
    }
}
