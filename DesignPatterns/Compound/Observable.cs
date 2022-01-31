using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DesignPatterns.Compound
{
    class Observable : QuackObservable
    {
        ArrayList observers = new ArrayList();
        QuackObservable duck;
        public Observable(QuackObservable duck) {
            this.duck = duck;
        }
        public void notifyObservers()
        {
            IEnumerator enumerator = observers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Observer observer = (Observer)enumerator.Current;
                observer.update(duck);
            }
        }

       public void registerObserver(Observer observer)
        {
            observers.Add(observer);
        }
    }
}
