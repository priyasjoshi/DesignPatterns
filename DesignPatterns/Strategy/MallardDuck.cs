using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Fly1 = new FlyWithWings();
            Quack1 = new QuackingDuck();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
