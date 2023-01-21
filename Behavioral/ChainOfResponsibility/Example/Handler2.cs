namespace DesignPatterns.ChainOfResponsibility.Example
{
    internal class Handler2 : BaseHandler
    {
        public override void Handle(string request)
        {
            Console.WriteLine("Hello! I am Handler2");
            Console.WriteLine("FINISH");
        }
    }
}
