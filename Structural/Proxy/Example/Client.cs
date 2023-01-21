namespace DesignPatterns.Proxy.Example
{
    internal class Client
    {
        public void Main()
        {
            IServiceInterface proxy = new Proxy(new Service());

            proxy.Operation();
        }
    }
}
