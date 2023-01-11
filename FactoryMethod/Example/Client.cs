namespace DesignPatterns.FactoryMethod.Example
{
    internal class Client
    {
        public void Main()
        {
            ICreator creator;

            string selection = Console.ReadLine();

            if (selection == "A")
            {
                creator = new CreatorA();
            }
            else
            {
                creator = new CreatorB();
            }

            IProduct product = creator.CreateProduct();

            product.SomeMethod();
        }
    }
}
