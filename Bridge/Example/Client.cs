using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Example
{
    internal class Client
    {
        public void Main()
        {
            IImplementation implementation;

            string selection = Console.ReadLine();

            if(selection == "1")
            {
                implementation = new Implementation1();
            }
            else
            {
                implementation = new Implementation2();
            }

            Abstraction abstraction = new Abstraction(implementation);

            abstraction.Feature1();
            abstraction.Feature2();
        }
    }
}
