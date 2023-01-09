using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Example
{
    internal class Implementation1 : IImplementation
    {
        public void Method1()
        {
            Console.WriteLine("Implementation1--Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Implementation1--Method2");
        }

        public void Method3()
        {
            Console.WriteLine("Implementation1--Method3");
        }
    }
}
