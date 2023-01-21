namespace DesignPatterns.State.Example
{
    internal class State3 : IState
    {
        private readonly Context context;

        public State3(Context context)
        {
            this.context = context;
        }

        public void Do()
        {
            Console.WriteLine("Hello! I am State3 method Do");
        }

        public void OtherDo()
        {
            Console.WriteLine("Hello! I am State3 method OtherDo");
        }
    }
}
