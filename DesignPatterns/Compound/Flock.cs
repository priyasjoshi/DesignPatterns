using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace DesignPatterns.Compound
{
    class Flock : Quackable
    {
        ArrayList ducks = new ArrayList();
        public void add(Quackable duck)
        {
            ducks.Add(duck);
        }
        public void notifyObservers()
        {
            
        }

        //Implement Iterator pattern
        public void quack() {
            IEnumerator enumerator = ducks.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Quackable duck = (Quackable)enumerator.Current;
                duck.quack();
            }
        }

        public void registerObserver(Observer observer)
        {
            IEnumerator enumerator = ducks.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Quackable duck = (Quackable)enumerator.Current;
                duck.registerObserver(observer);
            }
        }
    }
}
