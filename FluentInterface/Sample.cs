using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FluentInterface
{
    internal class Sample
    {
        public Sample MethodA()
        {
            Console.WriteLine("Method A executed");

            return this;
        }

        public Sample MethodB()
        {
            Console.WriteLine("Method B executed");

            return this;
        }

        public Sample MethodC()
        {
            Console.WriteLine("Method C executed");

            return this;
        }

        public Sample MethodD()
        {
            Console.WriteLine("Method D executed");

            return this;
        }

        public void TerminalMethod()
        {
            Console.WriteLine("END");
        }
    }
}
