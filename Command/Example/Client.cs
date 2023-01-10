using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Example
{
    internal class Client
    {
        public void Main()
        {
            ICommand command;

            var selection = Console.ReadLine();

            if (selection == "1")
            {
                command = new CommandA();
            }
            else
            {
                Receiver receiver = new Receiver();
                command = new CommandB(receiver);
            }


            Invoker invoker = new Invoker(command);

            invoker.Action();
        }
    }
}
