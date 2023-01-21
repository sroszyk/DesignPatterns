namespace DesignPatterns.Decorator.Example.OneFile
{
    #region COMPONENT

    // COMPONENT
    internal interface IComponent
    {
        void Execute();
    }

    internal class Component : IComponent
    {
        void IComponent.Execute()
        {
            Console.WriteLine("Hello! I am Concrete Component");
        }
    }

    #endregion

    #region DECORATOR

    //DECORATOR
    internal abstract class BaseDecorator : IComponent
    {
        private readonly IComponent wrappe;

        public BaseDecorator(IComponent wrappe)
        {
            this.wrappe = wrappe;
        }

        public virtual void Execute()
        {
            wrappe.Execute();
        }
    }

    internal class DecoratorA : BaseDecorator
    {
        public DecoratorA(IComponent wrappe) : base(wrappe)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Hello! I am DecoratorA");
            base.Execute();
        }
    }

    internal class DecoratorB : BaseDecorator
    {
        public DecoratorB(IComponent wrappe) : base(wrappe)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Hello! I am DecoratorB");
            base.Execute();
        }
    }

    #endregion
}
