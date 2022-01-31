using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class FreshClams : Clams
    {
        public void CreateClams()
        {
            Console.WriteLine("Using Fresh Clams...");
        }
    }
}
