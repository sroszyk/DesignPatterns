using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.Example
{
    internal class Service : IServiceInterface
    {
        public void Operation()
        {
            Console.WriteLine("Hello! I am Service");
        }
    }
}
