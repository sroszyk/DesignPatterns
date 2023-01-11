namespace DesignPatterns.State.Example
{
    internal class State1 : IState
    {
        private readonly Context context;

        public State1(Context context)
        {
            this.context = context;
        }

        public void Do()
        {
            Console.WriteLine("Hello! I am State1 method Do");
            context.ChangeState(new State2(context));
        }

        public void OtherDo()
        {
            Console.WriteLine("Hello! I am State1 method OtherDo");
        }
    }
}
