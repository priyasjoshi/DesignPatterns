using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class SoldState : State
    {
        GumballMachine GumballMachine;
        public SoldState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
        }
        public void dispense()
        {
            GumballMachine.releaseBall();
            if (GumballMachine.count > 0)
            {
                GumballMachine.setState(GumballMachine.getSoldState());
            }
            else {
                Console.WriteLine("oops,Out of gumballs!");
                GumballMachine.setState(GumballMachine.getSoldOutState());
            }
        }
        public void ejectQuarter()
        {
            Console.WriteLine("Sorry, You already turned the crank");
        }

        public void insertQuarter()
        {
            Console.WriteLine("Wait !! We're already giving you a gumball");
        }

        public void turnCrank()
        {
            Console.WriteLine("Turning twice won't work");
        }
    }
}
