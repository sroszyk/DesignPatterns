using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Example
{
    internal class Builder2 : IBuilder
    {
        private ProductB productB;

        public Builder2()
        {
            productB = new ProductB();
        }

        public void BuildStepA()
        {
            productB.Message += " --STEP_A/BUILDER_2--";
        }

        public void BuildStepB()
        {
            productB.Message += " --STEP_B/BUILDER_2--";
        }

        public void BuildStepC()
        {
            productB.Message += " --STEP_C/BUILDER_2--";
        }

        public void Reset()
        {
            productB = new ProductB();
        }

        public ProductB GetResult()
        {
            return productB;
        }
    }
}
