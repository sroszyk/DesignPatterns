namespace DesignPatterns.Strategy.Example
{
    internal class Context
    {
        private IStrategy strategy;

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void DoSomething()
        {
            Console.WriteLine("Context Actions!");
            strategy.Execute();
        }
    }
}
