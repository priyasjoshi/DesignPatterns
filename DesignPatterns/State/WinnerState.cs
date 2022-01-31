using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    class WinnerState : State
    {
        GumballMachine GumballMachine;
        public WinnerState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
        }
        public void dispense()
        {
            Console.WriteLine("YOU'RE A WINNER ! You get two gumballs for your quarter");
            GumballMachine.releaseBall();
            if (GumballMachine.count == 0)
            {
                GumballMachine.setState(GumballMachine.getSoldOutState());
            }
            else {
                GumballMachine.releaseBall();
                if (GumballMachine.count > 0)
                {
                    GumballMachine.setState(GumballMachine.getNoQuarterState());
                }
                else {
                    Console.WriteLine("Oops, out of gumballs!");
                    GumballMachine.setState(GumballMachine.getSoldOutState());
                }
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
