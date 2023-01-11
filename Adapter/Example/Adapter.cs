namespace DesignPatterns.Adapter.Example
{
    internal class Adapter : IClientInterface
    {
        private readonly Service adaptee;

        public Adapter(Service service)
        {
            this.adaptee = service;
        }

        public void Method(int data)
        {
            //COMPLEX DATA CONVERSION

            adaptee.ServiceMethod(data.ToString());
        }
    }
}
