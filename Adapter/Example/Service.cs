using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Example
{
    internal class Service
    {
        public void ServiceMethod(string data)
        {
            Console.WriteLine(data);
        }
    }
}
