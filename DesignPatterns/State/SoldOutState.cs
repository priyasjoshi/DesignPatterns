using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class soldOutState : State
    {
        GumballMachine GumballMachine;
        public soldOutState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
        }
        public void dispense()
        {
            Console.WriteLine("Sorry, Machine is out of gumballs.");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("NO Quarter.");
        }

        public void insertQuarter()
        {
            Console.WriteLine("No need of quarter");
        }

        public void turnCrank()
        {
            Console.WriteLine("Machine is out of gumballs");
        }
    }
}
