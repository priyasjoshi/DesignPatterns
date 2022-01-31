using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Compound
{
    interface Quackable:QuackObservable
    {
        void quack();
    }
}
