using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter.Example
{
    internal class TerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine("Hello! I am terminal Expression");
        }
    }
}
