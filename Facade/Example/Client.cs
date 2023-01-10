using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Example
{
    internal class Client
    {
        public void Main()
        {
            var facade = new Facade();

            facade.Execute();
        }
    }
}
