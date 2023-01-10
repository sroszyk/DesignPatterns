using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Example
{
    internal class CommandB : ICommand
    {
        private readonly Receiver receiver;

        public CommandB(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Hello! I am CommandB");
            receiver.Operation();
        }
    }
}
