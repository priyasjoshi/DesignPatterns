using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Compound
{
    class RubberDuck : Quackable
    {
        Observable Observable;
        public RubberDuck()
        {
            Observable = new Observable(this);
        }
        public void notifyObservers()
        {
            Observable.notifyObservers();
        }

        public void quack()
        {
            Console.WriteLine("Squeak");
            notifyObservers();
        }

        public void registerObserver(Observer observer)
        {
            Observable.registerObserver(observer);
        }
    }
}
