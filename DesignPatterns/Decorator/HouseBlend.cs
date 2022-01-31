using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class HouseBlend : Beverage
    {
        public HouseBlend() {
            Description = "House Blend";
        }
        public override double cost()
        {
            return 0.89;
        }
    }
}
