namespace DesignPatterns.Command.Example
{
    internal class Invoker
    {
        private readonly ICommand command;

        public Invoker(ICommand command)
        {
            this.command = command;
        }

        public void Action()
        {
            command.Execute();
        }
    }
}
