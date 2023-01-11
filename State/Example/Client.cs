namespace DesignPatterns.State.Example
{
    internal class Client
    {
        public void Main()
        {
            Context context = new Context();

            context.ContextDo();
            context.ContextOtherDo();
            context.ContextDo();
        }
    }
}
