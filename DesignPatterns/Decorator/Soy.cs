using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage) {
            this.beverage = beverage;
        }
        public override double cost()
        {
            return 0.15 + beverage.cost();
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ",Soy";
        }
    }
}
