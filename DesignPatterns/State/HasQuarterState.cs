using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class HasQuarterState : State
    {
        Random randomWinner = new Random(DateTime.Now.Millisecond);
        GumballMachine GumballMachine;
        public HasQuarterState(GumballMachine gumballMachine) {
            this.GumballMachine = gumballMachine;
        }
        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("We are returning a quarter.");
            GumballMachine.setState(GumballMachine.getNoQuarterState());
        }

        public void insertQuarter()
        {
            Console.WriteLine("You cannot insert another quarter.");
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(10);
            if (winner == 0 && GumballMachine.count > 1)
            {
                GumballMachine.setState(GumballMachine.getWinnerState());
            }
            else {
                GumballMachine.setState(GumballMachine.getSoldState());
            }
        }
    }
}
