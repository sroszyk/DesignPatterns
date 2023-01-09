using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.Example
{
    internal class Client
    {
        public void Main()
        {
            var composite = new Composite("Main");

            composite.AddChild(new Leaf("Leaf 1"));
            composite.AddChild(new Leaf("Leaf 2"));

            var composite2 = new Composite("Secondary");
            composite2.AddChild(new Leaf("Leaf 3"));
            composite2.AddChild(new Leaf("Leaf 4"));

            composite.AddChild(composite2);

            composite.Execute();
        }
    }
}
