using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying !!");
        }
    }
}
