namespace DesignPatterns.Proxy.Example
{
    internal class Service : IServiceInterface
    {
        public void Operation()
        {
            Console.WriteLine("Hello! I am Service");
        }
    }
}
