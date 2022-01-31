using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    class MenuItem : MenuComponent
    {
        string name;
        string description;
        bool vegetarian;
        double price;
        public MenuItem(string name,
                        string description,
                        bool vegetarian,
                        double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }
        public new string getName()
        {
            return name;
        }
        public new string getDescription()
        {
            return description;
        }
        public new double getPrice()
        {
            return price;
        }
        public new bool isVegetarian()
        {
            return vegetarian;
        }
        public new void print()
        {
            Console.WriteLine(" " + getName());
            if (isVegetarian())
            {
                Console.WriteLine("(v)");
            }
            Console.WriteLine(", " + getPrice());
            Console.WriteLine("   --- " + getDescription());
        }
    }
}
