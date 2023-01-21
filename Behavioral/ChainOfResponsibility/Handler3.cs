namespace DesignPatterns.ChainOfResponsibility
{
    internal class Handler3 : BaseHandler
    {
        public override void Handle(string request)
        {
            Console.WriteLine("Hello! I am Handler3");
            base.Handle(request);
        }
    }
}
