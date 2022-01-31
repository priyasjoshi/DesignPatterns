using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    class QuackingDuck : QuackBehavior
    {
       public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
