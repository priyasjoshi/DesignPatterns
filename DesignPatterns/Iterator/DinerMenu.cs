using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    class DinerMenu
    {
        static readonly int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem [] MenuItems;
        public DinerMenu() {
            MenuItems = new MenuItem[MAX_ITEMS];
            addItem("Vegetarian BLT","(Fakin') Bacon with lettuce & tomato on whole wheat", true,2.99);
            addItem("BLT","Bacon with lettuce & tomato on whole wheat",false,2.99);
            addItem("Soup of the day", "Soup of the day, with a side of potato salad",false,3.29);
            addItem("Hotdog","A hot dog with saurkrut, relish,onions, topped with cheese", false,3.05);
        }
        public void addItem(string name, string description, bool vegetarian, double price) {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.Error.WriteLine("Sorry, Menu is full! Can't add item to menu");
            }
            else {
                MenuItems[numberOfItems] = menuItem;
                numberOfItems = numberOfItems + 1;
            }
        }
        public Iterator createIterator() {
            return new DinerMenuIterator(MenuItems);
        }
    }
}
