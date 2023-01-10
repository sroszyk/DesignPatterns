using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Example
{
    internal class CommandA : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Hello! I am CommandA");
        }
    }
}
