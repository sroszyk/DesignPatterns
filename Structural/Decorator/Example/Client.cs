namespace DesignPatterns.Decorator.Example
{
    internal class Client
    {
        public void Main()
        {
            IComponent component = new Component();

            var decorA = new DecoratorA(component);
            var decorB = new DecoratorB(decorA);

            decorB.Execute();
        }
    }
}
