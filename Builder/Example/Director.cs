using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Example
{
    internal class Director
    {
        private readonly IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void Make(string type)
        {
            if(type == "simple")
            {
                builder.BuildStepA();
            }
            else
            {
                builder.BuildStepA();
                builder.BuildStepB();
                builder.BuildStepC();
            }
        }
    }
}
