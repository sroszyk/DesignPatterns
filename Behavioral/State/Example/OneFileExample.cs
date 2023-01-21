namespace DesignPatterns.State.Example.OneFile
{
    #region STATES

    //STATES

    internal interface IState
    {
        void Do();

        void OtherDo();
    }

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

    #endregion

    internal class Context
    {
        private IState state;

        public Context()
        {
            state = new State1(this);
        }

        public void ChangeState(IState state)
        {
            this.state = state;
        }

        public void ContextDo()
        {
            state.Do();
        }

        public void ContextOtherDo()
        {
            state.OtherDo();
        }
    }
}
