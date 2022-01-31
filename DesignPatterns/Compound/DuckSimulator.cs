using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Compound
{
    class DuckSimulator
    {
        public static void Main(string [] args) {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            simulator.simulate(duckFactory);
            Console.ReadKey();
        }
        void simulate(AbstractDuckFactory duckFactory) {
            Quackable mallardDuck = duckFactory.CreateMallardDuck();
            Quackable redheadDuck = duckFactory.CreateRedheadDuck();
            Quackable duckCall = duckFactory.CreateDuckCall();
            Quackable rubberDuck = duckFactory.CreateRubberDuck();
            Quackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("Duck Simulator: With Composite - Flocks");

            Flock flockofDucks = new Flock();

            flockofDucks.add(redheadDuck);
            flockofDucks.add(duckCall);
            flockofDucks.add(rubberDuck);
            flockofDucks.add(gooseDuck);

            Flock flockOfMallards = new Flock();

            Quackable mallardOne = duckFactory.CreateMallardDuck();
            Quackable mallardTwo = duckFactory.CreateMallardDuck();
            Quackable mallardThree = duckFactory.CreateMallardDuck();
            Quackable mallardFour = duckFactory.CreateMallardDuck();

            flockOfMallards.add(mallardOne);
            flockOfMallards.add(mallardTwo);
            flockOfMallards.add(mallardThree);
            flockOfMallards.add(mallardFour);

            flockofDucks.add(flockOfMallards);

            Console.WriteLine("Duck Simulator: With Observer");
            Quackologist quackologist = new Quackologist();
            flockofDucks.registerObserver(quackologist);

            simulate(flockofDucks);

            Console.WriteLine("Duck Simulator: Mallard Flock Simulation ");
            simulate(flockOfMallards);

            Console.WriteLine("The ducks quacked " + QuackCounter.getQuacks() + " times");
        }
        void simulate(Quackable duck) {
            duck.quack();
        }
    }
}
