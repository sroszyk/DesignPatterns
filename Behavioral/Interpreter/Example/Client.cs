namespace DesignPatterns.Interpreter.Example
{
    internal class Client
    {
        public void Main()
        {
            Context context = new Context();

            IExpression expression = new NonTerminalExpression(
                new TerminalExpression(),
                new TerminalExpression()
                );

            expression.Interpret(context);
        }
    }
}
