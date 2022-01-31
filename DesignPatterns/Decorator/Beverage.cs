using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class Beverage
    {
        public string Description = "Unknow Beverage";
        public string GetDescription() {
            return Description;
        }
        public abstract double cost();
    }
}
