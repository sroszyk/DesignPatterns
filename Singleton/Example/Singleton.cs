using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.Example
{
    internal class Singleton
    {
        private static Singleton instance;

        public string Message { get; set; }

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            } 

            return instance;
        }
    }
}
