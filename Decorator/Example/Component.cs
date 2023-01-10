using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Example
{
    internal class Component : IComponent
    {
        void IComponent.Execute()
        {
            Console.WriteLine("Hello! I am Concrete Component");
        }
    }
}
