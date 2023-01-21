namespace DesignPatterns.Command.Example.OneFile
{
    #region COMMANDS

    //COMMANDS
    internal interface ICommand
    {
        void Execute();
    }

    internal class CommandA : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Hello! I am CommandA");
        }
    }

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

    #endregion

    internal class Receiver
    {
        public void Operation()
        {
            Console.WriteLine("Hello! I am Receiver");
        }
    }

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
