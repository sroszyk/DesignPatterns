using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Example
{
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
}
