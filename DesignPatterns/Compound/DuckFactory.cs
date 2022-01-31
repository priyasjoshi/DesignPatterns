using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Compound
{
    class DuckFactory : AbstractDuckFactory
    {
        public override Quackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public override Quackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override Quackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override Quackable CreateRubberDuck()
        {
            return new DuckCall();
        }
    }
}
