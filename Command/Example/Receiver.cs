using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Example
{
    internal class Receiver
    {
        public void Operation()
        {
            Console.WriteLine("Hello! I am Receiver");
        }
    }
}
