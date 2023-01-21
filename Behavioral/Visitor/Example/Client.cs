namespace DesignPatterns.Visitor.Example
{
    internal class Client
    {
        public void Main()
        {
            IVisitor visitor = new ConcreteVisitor();

            ElementA elementA = new ElementA();
            ElementB elementB = new ElementB();

            elementA.Accept(visitor);
            elementB.Accept(visitor);
        }
    }
}
