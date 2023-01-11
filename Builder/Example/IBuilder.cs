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
