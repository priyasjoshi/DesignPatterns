using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DesignPatterns.Iterator
{
    class PancakeHouseMenuIterator : Iterator
    {
        ArrayList items;
        int position = 0;
        public PancakeHouseMenuIterator(ArrayList menuItems) {
            this.items = menuItems;
        }
        public bool hasnext()
        {
            if (position >= items.Count)
            {
                return false;
            }
            return true;
        }
        public object next()
        {
            MenuItem menuItem = (MenuItem)items[position];
            position = position + 1;
            return menuItem;
        }
    }
}
