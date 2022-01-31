using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Compound
{
    class MallardDuck : Quackable
    {
        Observable Observable;
        public MallardDuck()
        {
            Observable = new Observable(this);
        }

        public void notifyObservers()
        {
            Observable.notifyObservers();
        }

        public void quack()
        {
            Console.WriteLine("Quack");
            notifyObservers();
        }

        public void registerObserver(Observer observer)
        {
            Observable.registerObserver(observer);
        }
    }
}
