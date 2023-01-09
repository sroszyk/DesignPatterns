using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.Example
{
    internal class Client
    {
        public void Main()
        {
            var singleton = Singleton.GetInstance();
            singleton.Message = "Hello! I am Singleton";

            singleton = Singleton.GetInstance();

            Console.WriteLine(singleton.Message);
        }
    }
}
