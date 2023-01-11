namespace DesignPatterns.TemplateMethod.Example
{
    internal class ConcreteClassB : AbstractClass
    {
        public override void TemplateMethod()
        {
            base.TemplateMethod();
        }

        protected override void Step3()
        {
            Console.WriteLine("Hello! I am ConcreteClassB Step3");
        }
    }
}
