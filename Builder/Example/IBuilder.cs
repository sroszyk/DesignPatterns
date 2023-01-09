using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Example
{
    internal interface IBuilder
    {
        void Reset();

        void BuildStepA();

        void BuildStepB();

        void BuildStepC();
    }
}
