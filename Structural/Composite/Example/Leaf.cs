namespace DesignPatterns.Composite.Example
{
    internal class Leaf : IComponent
    {
        private readonly string name;

        public Leaf(string name)
        {
            this.name = name;
        }

        public void Execute()
        {
            Console.WriteLine(name);
        }
    }
}
