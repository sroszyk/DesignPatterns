using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FluentInterface
{
    internal class Client
    {
        public void Main()
        {
            var sample = new Sample();

            sample.MethodA()
                .MethodB()
                .MethodD()
                .TerminalMethod();
        }
    }
}
