namespace DesignPatterns.Facade.Example
{
    internal class Client
    {
        public void Main()
        {
            var facade = new Facade();

            facade.Execute();
        }
    }
}
