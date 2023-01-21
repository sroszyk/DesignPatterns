namespace DesignPatterns.Decorator.Example
{
    internal class DecoratorB : BaseDecorator
    {
        public DecoratorB(IComponent wrappe) : base(wrappe)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Hello! I am DecoratorB");
            base.Execute();
        }
    }
}
