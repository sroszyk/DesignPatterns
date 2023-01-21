namespace DesignPatterns.FactoryMethod.Example
{
    internal class CreatorA : ICreator
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}
