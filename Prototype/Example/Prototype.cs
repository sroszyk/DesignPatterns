using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Example
{
    internal class Prototype: IPrototype
    {
        private int secretValue = 50;

        private string anotherSecretValue = "Test";

        public Prototype()
        {
        }

        Prototype(Prototype prototype)
        {
            secretValue = prototype.secretValue;
            anotherSecretValue = prototype.anotherSecretValue;
        }

        public IPrototype Clone()
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
}
