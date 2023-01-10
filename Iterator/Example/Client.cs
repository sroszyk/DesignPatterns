using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Example
{
    internal class Client
    {
        public void Main()
        {
            IIterableCollection collection = new IterableCollection();

            var iterator = collection.GetIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.GetNext());
            }
        }
    }
}
