namespace DesignPatterns.Strategy.Example.OneFile
{
    #region STRATEGIES

    //STRATEGIES

    internal interface IStrategy
    {
        void Execute();
    }

    internal class StrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Hello! I am StrategyA");
        }
    }

    internal class StrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Hello! I am StrategyB");
        }
    }

    #endregion

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
