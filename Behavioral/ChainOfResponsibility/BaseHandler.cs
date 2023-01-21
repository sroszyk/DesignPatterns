namespace DesignPatterns.ChainOfResponsibility
{
    internal abstract class BaseHandler : IHandler
    {
        protected IHandler handler;

        public virtual void Handle(string request)
        {
            Console.WriteLine("Hello! I am BaseHandler");
            handler.Handle(request);
        }

        public void SetNext(IHandler handler)
        {
            this.handler = handler;
        }
    }
}
