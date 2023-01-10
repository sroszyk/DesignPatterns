using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter.Example
{
    internal interface IExpression
    {
        void Interpret(Context context);
    }
}
