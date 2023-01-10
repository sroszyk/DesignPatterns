using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter.Example
{
    internal class NonTerminalExpression : IExpression
    {
        private readonly IExpression left;
        private readonly IExpression right;

        public NonTerminalExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public void Interpret(Context context)
        {
            Console.WriteLine("Hello! I am NonTerminalExpression");
            right.Interpret(context);
            left.Interpret(context);
        }
    }
}
