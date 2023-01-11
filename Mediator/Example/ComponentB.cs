namespace DesignPatterns.Mediator.Example
{
    internal class ComponentB
    {
        private IMediator mediator;

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Operation()
        {
            Console.WriteLine("Hello! I am ComponentB");
            mediator.Notify(nameof(ComponentB));
        }
    }
}
