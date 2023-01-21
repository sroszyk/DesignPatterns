namespace DesignPatterns.TemplateMethod.Example
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
}
