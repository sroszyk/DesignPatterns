namespace DesignPatterns.TemplateMethod.Example.OneFile
{
    internal abstract class AbstractClass
    {
        public virtual void TemplateMethod()
        {
            Console.WriteLine("Hello! I am AbstractClass");
            Step1();
            Step2();
            Step3();
        }

        protected virtual void Step1()
        {
            Console.WriteLine("Hello! I am AbstractClass Step1");
        }

        protected virtual void Step2()
        {
            Console.WriteLine("Hello! I am AbstractClass Step2");
        }

        protected virtual void Step3()
        {
            Console.WriteLine("Hello! I am AbstractClass Step3");
        }
    }

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
