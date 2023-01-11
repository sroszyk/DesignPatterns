namespace DesignPatterns.Visitor.Example
{
    internal interface IVisitor
    {
        void Visit(ElementA elementA);

        void Visit(ElementB elementB);
    }
}
