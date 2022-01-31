using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class Espresso : Beverage
    {
        public Espresso() {
           Description = "Espresso";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
