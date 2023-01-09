using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Example
{
    internal class Client
    {
        public void Main()
        {
            Director director;

            var selection = Console.ReadLine();

            if (selection == "1")
            {
                var builder1 = new Builder1();
                director = new Director(builder1);

                director.Make("simple");

                var product = builder1.GetResult();

                Console.WriteLine(product.Message);
            }
            else
            {
                var builder2 = new Builder2();
                director = new Director(builder2);

                director.Make("complex");

                var product = builder2.GetResult();

                Console.WriteLine(product.Message);
            }
        }
    }
}
