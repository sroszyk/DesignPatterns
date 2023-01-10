using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Example
{
    internal class IterableCollection : IIterableCollection
    {
        private readonly int[] collection = new int[] { 1, 2, 3, 4, 5 };
        public IIterator GetIterator()
        {
            return new Iterator(this);
        }

        public int GetValue(int idx)
        {
            if(idx > collection.Length - 1)
            {
                return -1;
            }
            
            return collection[idx];
        }
    }
}
