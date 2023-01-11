namespace DesignPatterns.Decorator.Example
{
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
}
