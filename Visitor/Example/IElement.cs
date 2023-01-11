namespace DesignPatterns.Visitor.Example
{
    internal interface IElement
    {
        public void Accept(IVisitor visitor);
    }
}
