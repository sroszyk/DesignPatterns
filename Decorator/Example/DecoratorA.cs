namespace DesignPatterns.Decorator.Example
{
    internal class DecoratorA : BaseDecorator
    {
        public DecoratorA(IComponent wrappe) : base(wrappe)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Hello! I am DecoratorA");
            base.Execute();
        }
    }
}
