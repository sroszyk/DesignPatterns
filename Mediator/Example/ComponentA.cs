namespace DesignPatterns.Mediator.Example
{
    internal class ComponentA
    {
        private IMediator mediator;

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Operation()
        {
            Console.WriteLine("Hello! I am ComponentA");
            mediator.Notify(nameof(ComponentA));
        }
    }
}
