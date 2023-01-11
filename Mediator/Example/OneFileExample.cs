namespace DesignPatterns.Mediator.Example.OneFile
{
    #region COMPONENTS

    //COMPONENTS

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

    internal class ComponentC
    {
        private IMediator mediator;

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Operation()
        {
            Console.WriteLine("Hello! I am ComponentA");
            mediator.Notify(nameof(ComponentC));
        }
    }

    #endregion

    internal interface IMediator
    {
        void Notify(string sender);
    }

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
