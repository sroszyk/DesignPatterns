namespace DesignPatterns.TemplateMethod.Example
{
    internal class Client
    {
        public void Main()
        {
            AbstractClass abstractClass;

            string selector = Console.ReadLine();

            if (selector == "1")
            {
                abstractClass = new ConcreteClassA();
            }
            else
            {
                abstractClass = new ConcreteClassB();
            }

            abstractClass.TemplateMethod();
        }
    }
}
