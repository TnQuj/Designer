using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real16_Iterator
{
    public class Collection : IAbstractCollection
    {
        private List<Item> items = new List<Item>();

        public IteratorReal CreateIterator()
        {
            return new IteratorReal(this);
        }

        public int Count => items.Count;

        public Item this[int index]
        {
            get => items[index];
            set => items.Add(value);
        }
    }
}
