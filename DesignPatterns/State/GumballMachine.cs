using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class GumballMachine
    {
        static State soldOutState;
        static State noQuarterState;
        static State hasQuarterState;
        static State soldState;
        static State winnerState;
        State state = soldOutState;
        public int count = 0;
        public GumballMachine(int numberGumballs)
        {
            soldOutState = new soldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            this.count = numberGumballs;
            if (numberGumballs > 0)
            {
                state = noQuarterState;

            }
        }
        public void insertQuarter() {
            state.insertQuarter();
        }
        public void ejectQuarter()
        {
            state.ejectQuarter();
        }
        public void turnCrank() {
            state.turnCrank();
            state.dispense();
        }
       public void releaseBall() {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count!=0)
            {
                count = count - 1;
            }
        }
       public void setState(State state) {
            this.state = state;
        }
        //Getters for each state
        public State getNoQuarterState() {
            state = noQuarterState;
            return state;
        }
        public State getHasQuarterState()
        {
            state = hasQuarterState;
            return state;
        }
        public State getSoldState()
        {
            state = soldState;
            return state;
        }
        public State getSoldOutState()
        {
            state = soldOutState;
            return state;
        }
        public State getWinnerState()
        {
            state = winnerState;
            return state;
        }
    }
}
