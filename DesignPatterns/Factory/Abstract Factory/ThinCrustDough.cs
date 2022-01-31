using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class ThinCrustDough : Dough
    {
        public void CreateDough()
        {
            Console.WriteLine("Create Thin Crust Dough.");
        }
    }
}
