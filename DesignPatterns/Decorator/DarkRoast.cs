using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast() {
            this.Description = "Dark Roast";
        }
        public override double cost()
        {
            return 0.99;
        }
    }
}
