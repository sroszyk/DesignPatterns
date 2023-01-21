namespace DesignPatterns.Command.Example
{
    internal class CommandA : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Hello! I am CommandA");
        }
    }
}
