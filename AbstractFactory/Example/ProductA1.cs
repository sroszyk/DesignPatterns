using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Example
{
    internal class ProductA1 : IProductA
    {
        public void SomeMethod()
        {
            Console.WriteLine("Hello! I am Product A1");
        }
    }
}
