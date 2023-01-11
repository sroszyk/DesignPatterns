namespace DesignPatterns.Interpreter.Example
{
    internal interface IExpression
    {
        void Interpret(Context context);
    }
}
