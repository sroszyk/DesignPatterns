using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Example
{
    internal class Builder1 : IBuilder
    {
        private ProductA productA;

        public Builder1()
        {
            productA = new ProductA();
        }

        public void BuildStepA()
        {
            productA.Message += " --STEP_A/BUILDER_1--";
        }

        public void BuildStepB()
        {
            productA.Message += " --STEP_B/BUILDER_1--";
        }

        public void BuildStepC()
        {
            productA.Message += " --STEP_C/BUILDER_1--";
        }

        public void Reset()
        {
            productA = new ProductA();
        }

        public ProductA GetResult()
        {
            return productA;
        }
    }
}
