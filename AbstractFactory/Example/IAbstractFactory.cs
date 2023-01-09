namespace DesignPatterns.AbstractFactory.Example
{
    internal interface IAbstractFactory
    {
        IProductA CreateProductA();

        IProductB CreateProductB();
    }
}
