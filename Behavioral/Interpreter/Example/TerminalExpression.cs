namespace DesignPatterns.Interpreter.Example
{
    internal class TerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine("Hello! I am terminal Expression");
        }
    }
}
