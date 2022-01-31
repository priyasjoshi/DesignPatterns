using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class PizzaTestDrive
    {
        public static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            Pizza nyPizza = nyStore.orderPizza("Cheese");
            Console.WriteLine("Ethan ordered a " + nyPizza.getName() + "\n");
            Console.ReadKey();
        }
    }
}
