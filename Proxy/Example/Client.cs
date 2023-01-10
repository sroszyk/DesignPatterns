using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.Example
{
    internal class Client
    {
        public void Main()
        {
            IServiceInterface proxy = new Proxy(new Service());

            proxy.Operation();
        }
    }
}
