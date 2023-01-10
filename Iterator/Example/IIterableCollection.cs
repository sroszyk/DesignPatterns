using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Example
{
    internal interface IIterableCollection
    {
        IIterator GetIterator();
    }
}
