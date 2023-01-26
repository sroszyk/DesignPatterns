namespace DesignPatterns.Prototype.Example.OneFile
{
    internal interface IPrototype
    {
        IPrototype Clone();
    }

    public class Test123
    {

    }

    internal class Prototype : IPrototype
    {
        private int secretValue = 50;

        private string anotherSecretValue = "Test";

        private Test123 test123;

        public Prototype()
        {
        }

        protected Prototype(Prototype prototype)
        {
            secretValue = prototype.secretValue;
            anotherSecretValue = prototype.anotherSecretValue;
            test123 = prototype.test123;
        }

        public virtual IPrototype Clone()
        {
            return new Prototype(this);
        }

        public void SetSecretValue(int value)
        {
            secretValue = value;
        }

        public void SetAnotherSecretValue(string value)
        {
            anotherSecretValue = value;
        }

        public void PrintValues()
        {
            Console.WriteLine(secretValue.ToString());
            Console.WriteLine(anotherSecretValue);
        }
    }

    internal class SubPrototype: Prototype
    {
        public SubPrototype()
        {
        }

        protected SubPrototype(SubPrototype subPrototype): base(subPrototype)
        {
        }

        public override IPrototype Clone()
        {
            return new SubPrototype(this);
        }
    }
}
