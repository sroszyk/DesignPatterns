using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Example
{
    internal class Client
    {
        public void Main()
        {
            IClientInterface adapter = new Adapter(new Service());

            adapter.Method(55);
        }
    }
}
