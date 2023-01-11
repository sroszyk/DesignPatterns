namespace DesignPatterns.Visitor.Example
{
    internal class ElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
