using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Example
{
    internal class ProductA2 : IProductA
    {
        public void SomeMethod()
        {
            Console.WriteLine("Hello! I am Product A2");
        }
    }
}
