namespace DesignPatterns.Command.Example
{
    internal class CommandB : ICommand
    {
        private readonly Receiver receiver;

        public CommandB(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Hello! I am CommandB");
            receiver.Operation();
        }
    }
}
