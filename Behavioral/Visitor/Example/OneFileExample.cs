namespace DesignPatterns.Visitor.Example.OneFile
{
    #region ELEMENTS

    //ELEMENTS
    internal interface IElement
    {
        public void Accept(IVisitor visitor);
    }

    internal class ElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    internal class ElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    #endregion

    #region VISITORS

    //VISITORS
    internal interface IVisitor
    {
        void Visit(ElementA elementA);

        void Visit(ElementB elementB);
    }

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

    #endregion
}
