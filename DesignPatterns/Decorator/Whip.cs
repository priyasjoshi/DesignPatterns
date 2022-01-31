using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage) {
            this.beverage = beverage;
        }
        public override double cost()
        {
            return 0.10 + beverage.cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ",Whip";
        }
    }
}
