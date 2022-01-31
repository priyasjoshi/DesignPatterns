using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    class NullIterator : Iterator.Iterator
    {
        public bool hasnext()
        {
            return false;
        }
        public object next()
        {
            return null;
        }
        public void remove() {
            throw new NotSupportedException();
        }
    }
}
