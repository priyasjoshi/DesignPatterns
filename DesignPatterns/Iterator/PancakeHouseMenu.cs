using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DesignPatterns.Iterator
{
    class PancakeHouseMenu
    {
        ArrayList menuItems;
        public PancakeHouseMenu() {
            menuItems = new ArrayList();
            addItem("K&B's Pancake Breakfast", "Pancake with Scrambled eggs, and toast",true,2.99);
            addItem("Regular Pancake Breakfast", "Pabcake with fried eggs, sausage",false,2.99);
            addItem("Blueberry Pancakes", "Pancakes made with fresh blueberries",true,3.49);
            addItem("Waffles","Waffles with your choice of blueberries or strawberries",true,3.59);
        }
        public void addItem(string name,string description,bool vegetarian,double price) {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }
        public Iterator createIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}
