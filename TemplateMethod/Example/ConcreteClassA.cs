namespace DesignPatterns.TemplateMethod.Example
{
    internal class ConcreteClassA : AbstractClass
    {
        public override void TemplateMethod()
        {
            base.TemplateMethod();
        }

        protected override void Step1()
        {
            Console.WriteLine("Hello! I am ConcreteClassA Step1");
        }
    }
}
