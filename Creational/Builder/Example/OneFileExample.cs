namespace DesignPatterns.Builder.Example.OneFile
{
    #region BUILDERS

    //BUILDERS
    internal interface IBuilder
    {
        void Reset();

        void BuildStepA();

        void BuildStepB();

        void BuildStepC();
    }

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

    #endregion

    #region PRODUCTS

    // PRODUCTS
    internal class ProductA
    {
        public string Message { get; set; }
    }

    internal class ProductB
    {
        public string Message { get; set; }
    }

    #endregion

    //DIRECTOR
    internal class Director
    {
        private readonly IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void Make(string type)
        {
            if (type == "simple")
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
