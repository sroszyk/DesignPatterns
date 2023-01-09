using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Example.OneFile
{
    internal interface IClientInterface
    {
        public void Method(int data);
    }

    internal class Adapter : IClientInterface
    {
        private readonly Service adaptee;

        public Adapter(Service service)
        {
            this.adaptee = service;
        }

        public void Method(int data)
        {
            //COMPLEX DATA CONVERSION

            adaptee.ServiceMethod(data.ToString());
        }
    }

    internal class Service
    {
        public void ServiceMethod(string data)
        {
            Console.WriteLine(data);
        }
    }
}
