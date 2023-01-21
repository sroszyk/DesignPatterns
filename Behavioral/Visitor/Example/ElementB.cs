namespace DesignPatterns.Visitor.Example
{
    internal class ElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
