using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiNgocQui_DPM225464_Real16_Iterator
{
    public class IteratorReal
    {
        private readonly Collection collection;
        private int current = 0;
        public int Step { get; set; } = 1;

        public IteratorReal(Collection collection)
        {
            this.collection = collection;
        }

        public Item First()
        {
            current = 0;
            return collection[0];
        }

        public Item Next()
        {
            current += Step;
            if (!IsDone())
                return collection[current];
            else
                return null;
        }

        public bool IsDone()
        {
            return current >= collection.Count;
        }

        public Item CurrentItem()
        {
            return collection[current];
        }
    }
}
