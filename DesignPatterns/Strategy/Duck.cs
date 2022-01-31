using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public abstract class Duck
    {
        public FlyBehavior Fly1;
        public QuackBehavior Quack1;
        public abstract void Display();
        public void performFly()
        {
            Fly1.Fly();
        }
        public void performQuack()
        {
            Quack1.Quack();
        }
        public void Swim()
        {
            Console.WriteLine("All Ducks float, Even Decoys !!");
        }
        public void setFlyBehavior(FlyBehavior fb)
        {
            Fly1 = fb;
        }
        public void setQuackBehvior(QuackBehavior qb) {
            Quack1 = qb;
        }
    }
}
