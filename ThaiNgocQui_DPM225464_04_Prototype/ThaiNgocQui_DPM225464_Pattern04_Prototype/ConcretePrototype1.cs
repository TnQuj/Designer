using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Pattern04_Prototype
{
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id) { }

        public override Prototype Clone()
        {
            // Shallow copy
            return (Prototype)this.MemberwiseClone();
        }
    }

}
