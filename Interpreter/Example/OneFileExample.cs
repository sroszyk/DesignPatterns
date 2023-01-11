namespace DesignPatterns.Interpreter.Example.OneFile
{
    internal interface IExpression
    {
        void Interpret(Context context);
    }

    internal class Context
    {
    }

    internal class TerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine("Hello! I am terminal Expression");
        }
    }

    internal class NonTerminalExpression : IExpression
    {
        private readonly IExpression left;
        private readonly IExpression right;

        public NonTerminalExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public void Interpret(Context context)
        {
            Console.WriteLine("Hello! I am NonTerminalExpression");
            right.Interpret(context);
            left.Interpret(context);
        }
    }

}
