namespace DesignPatterns.Mediator.Example
{
    internal class Mediator : IMediator
    {
        private readonly ComponentA componentA;
        private readonly ComponentB componentB;
        private readonly ComponentC componentC;

        public Mediator(ComponentA componentA, ComponentB componentB, ComponentC componentC)
        {
            this.componentA = componentA;
            this.componentB = componentB;
            this.componentC = componentC;
        }

        public void Notify(string sender)
        {
            switch (sender)
            {
                case nameof(ComponentA):
                    Console.WriteLine("React on A");
                    break;
                case nameof(ComponentB):
                    Console.WriteLine("React on B");
                    break;
                case nameof(ComponentC):
                    Console.WriteLine("React on C");
                    break;
                default:
                    break;
            }
        }
    }
}
