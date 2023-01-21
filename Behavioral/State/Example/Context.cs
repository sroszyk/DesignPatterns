namespace DesignPatterns.State.Example
{
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
