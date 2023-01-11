namespace DesignPatterns.Prototype.Example
{
    internal class Client
    {
        public void Main()
        {
            Prototype prototype = new Prototype();

            prototype.SetAnotherSecretValue("SUPER TEST");
            prototype.SetSecretValue(999);

            var copyPrototype = prototype.Clone();
            ((Prototype)copyPrototype).PrintValues();
        }
    }
}
