namespace DesignPatterns.Proxy.Example
{
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
