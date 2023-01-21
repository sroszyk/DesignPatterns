namespace DesignPatterns.AbstractFactory.Example
{
    internal class Client
    {
        public void Main()
        {
            IAbstractFactory factory;

            string selection = Console.ReadLine();

            if (selection == "1")
            {
                factory = new Factory1();
            }
            else
            {
                factory = new Factory2();
            }

            IProductA productA = factory.CreateProductA();
            IProductB productB = factory.CreateProductB();

            productA.SomeMethod();
            productB.SomeMethod();
        }
    }
}
