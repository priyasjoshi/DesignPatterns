using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace DesignPatterns.Composite
{
    class Menu:MenuComponent
    {
        ArrayList menuComponents = new ArrayList();
        string name;
        string description;
        DesignPatterns.Iterator.Iterator iterator = null;

        public Menu(string name,string description) {
            this.name = name;
            this.description = description;
        }
        public void add(MenuComponent menuComponent) {
            menuComponents.Add(menuComponent);
        }
        public void remove(MenuComponent menuComponent) {
            menuComponents.Remove(menuComponent);
        }
        public MenuComponent getChild(int i) {
            return (MenuComponent)menuComponents[i];
        }
        public string getName()
        {
            return name;
        }
        public string getDescription()
        {
            return description;
        }
        public void print() {
            Console.WriteLine("\n" + getName());
            Console.WriteLine(", " + getDescription());
            Console.WriteLine("----------------------");
            IEnumerator enumerator = menuComponents.GetEnumerator();
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                menuComponent.print();
            }
        }
        public DesignPatterns.Iterator.Iterator createIterator() {
            if (iterator==null)
            {
                //Figure out Iterator logic for C# collections and implement this
                //MenuComponent is an arraylist...
                //iterator = new Composite.CompositeIterator(menuComponents);
            }
            return iterator;
        }
    }
}
