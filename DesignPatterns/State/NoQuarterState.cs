using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class NoQuarterState : State
    {
        GumballMachine gumballMachine;
        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void dispense()
        {
            Console.WriteLine("Hey, You have to insert quarter to get gumballs !!");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Hey, You haven't inserted a quarter !!");
        }

        public void insertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.setState(gumballMachine.getHasQuarterState());    
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there is no quarter");
        }
    }
}
