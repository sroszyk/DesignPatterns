namespace DesignPatterns.Strategy.Example
{
    internal class StrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Hello! I am StrategyA");
        }
    }
}
