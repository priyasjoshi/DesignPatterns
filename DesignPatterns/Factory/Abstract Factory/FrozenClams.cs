using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class FrozenClams:Clams
    {
        public void CreateClams()
        {
            Console.WriteLine("Using Frozen Clams...");
        }
    }
}
