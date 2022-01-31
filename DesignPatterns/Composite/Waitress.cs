using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    class Waitress
    {
        MenuComponent allMenus;
        public Waitress(MenuComponent allMenus) {
            this.allMenus = allMenus;
        }
        public void printMenu() {
            allMenus.print();
        }
        public void printVegeratianMenu() {
           DesignPatterns.Iterator.Iterator iterator = allMenus.createIterator();
           Console.WriteLine("\nVEGETARIAN MENU\n----");
            while (iterator.hasnext())
            {
                MenuComponent menuComponent = (MenuComponent)iterator.next();
                try
                {
                    if (menuComponent.isVegetarian())
                    {
                        menuComponent.print();
                    }
                }
                catch (NotSupportedException e)
                {
                    throw e;
                }
            }
        }
    }
}
