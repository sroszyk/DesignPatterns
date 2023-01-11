namespace DesignPatterns.Mediator.Example
{
    internal class Client
    {
        public void Main()
        {
            var componentA = new ComponentA();
            var componentB = new ComponentB();
            var componentC = new ComponentC();

            IMediator mediator = new Mediator(componentA, componentB, componentC);

            componentA.SetMediator(mediator);
            componentB.SetMediator(mediator);
            componentC.SetMediator(mediator);

            componentA.Operation();
        }
    }
}
