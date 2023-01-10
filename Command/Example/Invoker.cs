using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Example
{
    internal class Invoker
    {
        private readonly ICommand command;

        public Invoker(ICommand command)
        {
            this.command = command;
        }

        public void Action()
        {
            command.Execute();
        }
    }
}
