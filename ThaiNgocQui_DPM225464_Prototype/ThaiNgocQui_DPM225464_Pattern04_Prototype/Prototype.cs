using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Pattern04_Prototype
{
    abstract class Prototype
    {
        public string Id { get; private set; }

        public Prototype(string id)
        {
            Id = id;
        }

        public abstract Prototype Clone();
    }
}
