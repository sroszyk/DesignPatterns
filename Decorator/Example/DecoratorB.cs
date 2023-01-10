using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Example
{
    internal class DecoratorB : BaseDecorator
    {
        public DecoratorB(IComponent wrappe) : base(wrappe)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Hello! I am DecoratorB");
            base.Execute();
        }
    }
}
