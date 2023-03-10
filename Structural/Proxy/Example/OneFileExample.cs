namespace DesignPatterns.Proxy.Example.OneFile
{
    internal interface IServiceInterface
    {
        void Operation();
    }

    internal class Service : IServiceInterface
    {
        public void Operation()
        {
            Console.WriteLine("Hello! I am Service");
        }
    }

    internal class Proxy : IServiceInterface
    {
        private readonly IServiceInterface service;

        public Proxy(IServiceInterface service)
        {
            this.service = service;
        }

        public void Operation()
        {
            Console.WriteLine("Hello! I am Proxy");
            service.Operation();
        }
    }
}
