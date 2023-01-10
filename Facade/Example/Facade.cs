using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Example
{
    internal class Facade
    {
        public void Execute()
        {
            Console.WriteLine("External systems actions");
            Console.WriteLine("External libraries actions");
        }
    }
}
