namespace DesignPatterns.Bridge.Example.OneFile
{
    #region IMPLEMENTATIONS

    //IMPLEMENTATIONS

    internal interface IImplementation
    {
        public void Method1();

        public void Method2();

        public void Method3();
    }

    internal class Implementation1 : IImplementation
    {
        public void Method1()
        {
            Console.WriteLine("Implementation1--Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Implementation1--Method2");
        }

        public void Method3()
        {
            Console.WriteLine("Implementation1--Method3");
        }
    }

    internal class Implementation2 : IImplementation
    {
        public void Method1()
        {
            Console.WriteLine("Implementation2--Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Implementation2--Method2");
        }

        public void Method3()
        {
            Console.WriteLine("Implementation2--Method3");
        }
    }

    #endregion

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
