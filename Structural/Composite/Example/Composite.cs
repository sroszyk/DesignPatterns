namespace DesignPatterns.Composite.Example
{
    internal class Composite : IComponent
    {
        private readonly string name;
        private readonly List<IComponent> children = new List<IComponent>();

        public Composite(string name)
        {
            this.name = name;
        }

        public void AddChild(IComponent component)
        {
            children.Add(component);
        }

        public void Execute()
        {
            Console.WriteLine(name);
            foreach (var child in children)
            {
                child.Execute();
            }
        }
    }
}
