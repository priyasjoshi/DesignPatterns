using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Compound
{
    interface Observer
    {
        void update(QuackObservable duck);
    }
}
