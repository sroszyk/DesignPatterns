namespace DesignPatterns.Visitor.Example
{
    internal class ConcreteVisitor : IVisitor
    {
        public void Visit(ElementA elementA)
        {
            Console.WriteLine("Hello! I am ConcreteVisitorA for ElementA");
        }

        public void Visit(ElementB elementB)
        {
            Console.WriteLine("Hello! I am ConcreteVisitorA for ElementB");
        }
    }
}
