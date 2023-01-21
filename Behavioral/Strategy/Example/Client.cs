namespace DesignPatterns.Strategy.Example
{
    internal class Client
    {
        public void Main()
        {
            Context context = new Context();

            var selection = Console.ReadLine();

            if (selection == "1")
            {
                context.SetStrategy(new StrategyA());
            }
            else
            {
                context.SetStrategy(new StrategyB());
            }

            context.DoSomething();
        }
    }
}
