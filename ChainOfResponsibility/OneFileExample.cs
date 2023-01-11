namespace DesignPatterns.ChainOfResponsibility.ONeFile
{
    internal interface IHandler
    {
        void SetNext(IHandler handler);

        void Handle(string request);
    }

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

    internal class Handler1 : BaseHandler
    {
        public override void Handle(string request)
        {
            Console.WriteLine("Hello! I am Handler1");
            base.Handle(request);
        }
    }

    internal class Handler2 : BaseHandler
    {
        public override void Handle(string request)
        {
            Console.WriteLine("Hello! I am Handler2");
            Console.WriteLine("FINISH");
        }
    }

    internal class Handler3 : BaseHandler
    {
        public override void Handle(string request)
        {
            Console.WriteLine("Hello! I am Handler3");
            base.Handle(request);
        }
    }
}
