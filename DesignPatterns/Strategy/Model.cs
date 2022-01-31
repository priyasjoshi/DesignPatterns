using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    class Model : Duck
    {
        public Model() {
            Fly1 = new FlyNoWay();
            Quack1 = new MuteQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a model Duck");
        }
    }
}
