using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace DesignPatterns.Factory
{
    abstract class Pizza
    {
        public string name;
        public Dough dough;
        public Sauce sauce;
        public Cheese cheese;
        public Clams clam;
        public ArrayList toppings = new ArrayList();
        public void prepare() {
            //Console.WriteLine("Preparing " + name);
            //Console.WriteLine("Tossing dough... " + dough);
            //Console.WriteLine("adding " + sauce);
            //Console.WriteLine("Adding toppings: " + name);
            //for (int i = 0; i < toppings.Count; i++)
            //{
            //    Console.WriteLine(" " + toppings[i]);
            //}
        }
        public void bake() {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public void cut() {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public void box() {
            Console.WriteLine("Place pizza in official pizza store box");
        }
        public string getName() {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
}
