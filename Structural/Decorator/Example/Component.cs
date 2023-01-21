namespace DesignPatterns.Decorator.Example
{
    internal class Component : IComponent
    {
        void IComponent.Execute()
        {
            Console.WriteLine("Hello! I am Concrete Component");
        }
    }
}
