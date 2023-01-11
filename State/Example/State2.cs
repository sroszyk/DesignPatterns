namespace DesignPatterns.State.Example
{
    internal class State2 : IState
    {
        private readonly Context context;

        public State2(Context context)
        {
            this.context = context;
        }

        public void Do()
        {
            Console.WriteLine("Hello! I am State2 method Do");
        }

        public void OtherDo()
        {
            Console.WriteLine("Hello! I am State2 method OtherDo");
            context.ChangeState(new State3(context));
        }
    }
}
