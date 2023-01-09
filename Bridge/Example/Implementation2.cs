using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Example
{
    internal class Implementation2 : IImplementation
    {
        public void Method1()
        {
            Console.WriteLine("Implementation2--Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Implementation2--Method2");
        }

        public void Method3()
        {
            Console.WriteLine("Implementation2--Method3");
        }
    }
}
