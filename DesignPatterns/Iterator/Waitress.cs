﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;
        public Waitress(PancakeHouseMenu pancakeHouseMenu,DinerMenu dinerMenu) {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }
        public void printMenu() {
            Iterator pancakeIterator = pancakeHouseMenu.createIterator();
            Iterator dinerIterator = dinerMenu.createIterator();
            Console.WriteLine("MENU\n-----\nBREAKFAST");
            printMenu(pancakeIterator);
            Console.WriteLine("MENU\n-----\nLUNCH");
            printMenu(dinerIterator);
        }
        private void printMenu(Iterator iterator) {
            while (iterator.hasnext())
            {
                MenuItem menuItem = (MenuItem)iterator.next();
                Console.WriteLine(menuItem.getName() + ", ");
                Console.WriteLine(menuItem.getPrice() +", ");
                Console.WriteLine(menuItem.getDescription());
            }
        }
    }
}
