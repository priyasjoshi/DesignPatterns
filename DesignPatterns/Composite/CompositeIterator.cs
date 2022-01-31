using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DesignPatterns.Composite;

namespace DesignPatterns.Composite
{
   public class CompositeIterator : DesignPatterns.Iterator.Iterator
    {
        Stack stack = new Stack();
        public CompositeIterator(DesignPatterns.Iterator.Iterator iterator) {
            stack.Push(iterator);
        }
        public bool hasnext()
        {
            if (stack.Count > 0)
            {
                return false;
            }
            else {
                DesignPatterns.Iterator.Iterator iterator = (DesignPatterns.Iterator.Iterator)stack.Peek();
                if (!iterator.hasnext())
                {
                    stack.Pop();
                    return hasnext();
                }
                else {
                    return true;
                }
            }
        }

        public object next()
        {
            if (hasnext())
            {
                DesignPatterns.Iterator.Iterator iterator = (DesignPatterns.Iterator.Iterator)stack.Peek();
                MenuComponent component = (MenuComponent)iterator.next();
                if (component is Menu)
                {
                    stack.Push(component.createIterator());
                }
                return component;
            }
            else {
                return null;
            }
            
        }

        public void remove() {
            throw new NotSupportedException();
        }
    }
}
