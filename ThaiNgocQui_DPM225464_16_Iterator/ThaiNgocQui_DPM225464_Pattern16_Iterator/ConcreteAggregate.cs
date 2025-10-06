using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Pattern16_Iterator
{
    public class ConcreteAggregate : AbstractAggregate
    {
        private object[] items = new object[10];

        public object this[int index]
        {
            get => items[index];
            set => items[index] = value;
        }

        public int Count
        {
            get
            {
                int count = 0;
                foreach (var item in items)
                    if (item != null) count++;
                return count;
            }
        }

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
