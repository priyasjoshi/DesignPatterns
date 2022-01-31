using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    abstract class MenuComponent
    {
        public void add(MenuComponent menuComponent) {
            throw new NotSupportedException();
        }
        public void remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }
        public MenuComponent getChild(int i) {
            throw new NotSupportedException();
        }
        public string getName()
        {
            throw new NotSupportedException();
        }
        public string getDescription()
        {
            throw new NotSupportedException();
        }
        public double getPrice()
        {
            throw new NotSupportedException();
        }
        public bool isVegetarian()
        {
            throw new NotSupportedException();
        }
        public void print() {
            throw new NotSupportedException();
        }
        public DesignPatterns.Iterator.Iterator createIterator()
        {
            throw new NotSupportedException();
        }
    }
}
