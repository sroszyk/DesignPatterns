namespace DesignPatterns.ChainOfResponsibility
{
    internal class Handler1 : BaseHandler
    {
        public override void Handle(string request)
        {
            Console.WriteLine("Hello! I am Handler1");
            base.Handle(request);
        }
    }
}
