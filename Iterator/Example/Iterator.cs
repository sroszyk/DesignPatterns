using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Example
{
    internal class Iterator : IIterator
    {
        private readonly IterableCollection collection;
        private int state = 0;

        public Iterator(IterableCollection collection)
        {
            this.collection = collection;
        }

        public int GetNext()
        {
            var result = collection.GetValue(state);

            state++;

            return result;
        }

        public bool HasNext()
        {
            return collection.GetValue(state + 1) != -1;
        }
    }
}
