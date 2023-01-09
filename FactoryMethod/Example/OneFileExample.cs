namespace DesignPatterns.FactoryMethod.Example.OneFile
{
    // CREATORS
    internal interface ICreator
    {
        IProduct CreateProduct();
    }

    internal class CreatorA : ICreator
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }
    }

    internal class CreatorB : ICreator
    {
        public IProduct CreateProduct()
        {
            return new ProductB();
        }
    }

    // PRODUCTS
    internal interface IProduct
    {
        void SomeMethod();
    }

    internal class ProductA : IProduct
    {
        public void SomeMethod()
        {
            Console.WriteLine("Hello! I am Product A");
        }
    }

    internal class ProductB : IProduct
    {
        public void SomeMethod()
        {
            Console.WriteLine("Hello! I am Product B");
        }
    }
}
