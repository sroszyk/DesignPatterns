namespace DesignPatterns.FluentInterface
{
    internal class Client
    {
        public void Main()
        {
            var sample = new Sample();

            sample.MethodA()
                .MethodB()
                .MethodD()
                .TerminalMethod();
        }
    }
}
