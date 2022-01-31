using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Compound
{
    class DuckCall : Quackable
    {
        Observable Observable;
        public DuckCall() {
            Observable = new Observable(this);
        }
        public void notifyObservers()
        {
            Observable.notifyObservers();
        }

        public void quack()
        {
            Console.WriteLine("Kwak");
            notifyObservers();
        }

        public void registerObserver(Observer observer)
        {
            Observable.registerObserver(observer);
        }
    }
}
