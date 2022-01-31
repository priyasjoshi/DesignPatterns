using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Compound
{
    class Quackologist : Observer
    {
        public void update(QuackObservable duck)
        {
            Console.WriteLine("Quackologist: " + duck + " just Quacked.");
        }
    }
}
