using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Example
{
    internal class Client
    {
        public void Main()
        {
            IComponent component = new Component();

            var decorA = new DecoratorA(component);
            var decorB = new DecoratorB(decorA);

            decorB.Execute();
        }
    }
}
