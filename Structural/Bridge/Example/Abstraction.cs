namespace DesignPatterns.Bridge.Example
{
    internal class Abstraction
    {
        private readonly IImplementation implementation;

        public Abstraction(IImplementation implementation)
        {
            this.implementation = implementation;
        }

        public void Feature1()
        {
            implementation.Method1();
            implementation.Method2();
        }

        public void Feature2()
        {
            implementation.Method3();
        }
    }
}
