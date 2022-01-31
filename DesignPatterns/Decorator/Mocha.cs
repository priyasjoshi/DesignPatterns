using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class Mocha :CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage) {
            this.beverage = beverage;
        }
        public override double cost()
        {
            return 0.20 + beverage.cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ",Mocha";
        }
    }
}
