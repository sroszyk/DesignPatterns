using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.Example
{
    internal class Proxy: IServiceInterface
    {
        private readonly IServiceInterface service;

        public Proxy(IServiceInterface service)
        {
            this.service = service;
        }

        public void Operation()
        {
            Console.WriteLine("Hello! I am Proxy");
            service.Operation();
        }
    }
}
