namespace DesignPatterns.Adapter.Example
{
    internal class Client
    {
        public void Main()
        {
            IClientInterface adapter = new Adapter(new Service());

            adapter.Method(55);
        }
    }
}
