namespace DesignPatterns.FactoryMethod.Example
{
    internal class CreatorB : ICreator
    {
        public IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}
